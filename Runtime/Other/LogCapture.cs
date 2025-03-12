using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace OSKDevTool
{
    public class LogCapture : MonoBehaviour
    {
        public static LogCapture Instance;
        public List<string> logMessages = new List<string>();
        public bool isLogEnabled = false;
        private string logFilePath;
        private int logMaxLine = 25;

        private void Awake()
        {
            Instance = this;
            if (isLogEnabled) Application.logMessageReceived += HandleLog;
        }

        private void OnDestroy()
        {
            if (isLogEnabled) Application.logMessageReceived -= HandleLog;
        }

        private void HandleLog(string logString, string stackTrace, LogType type)
        { 
            string color = "";
            if(type == LogType.Error || type == LogType.Exception) color= "#FF0000"; // Red 
            else if(type == LogType.Warning) color= "#FFFF00"; // Yellow 
            else color= "#FFFFFF"; // White 

            string logEntry = $"<color={color}>{System.DateTime.Now} [{type}] {logString}</color>\n";

            if (type == LogType.Error || type == LogType.Exception)
            {
                logEntry += $"<color={color}>StackTrace: {stackTrace}</color>\n";
            }
            if (logMessages.Count >= logMaxLine) logMessages.RemoveAt(0);
            logMessages.Add(logEntry);
        }
        
        
        [ContextMenu("Enable Logs")]
        public void EnableLog()
        {
            isLogEnabled = true;
            Application.logMessageReceived += HandleLog;
        }
        
        [ConsoleCommand("cs_loggs_enable")]
        public void EnableLog(bool enable)
        {
            isLogEnabled = enable;
            if (isLogEnabled) Application.logMessageReceived += HandleLog;
            else Application.logMessageReceived -= HandleLog;
        }
        
        [ConsoleCommand("cs_export_loggs_txt")]
        [ContextMenu("Export Logs")]
        public void ExportLogToFile()
        {
            logFilePath = System.IO.Path.Combine(Application.persistentDataPath, "LogCapture.txt");
            if(logFilePath == null || !File.Exists(logFilePath))
            {
                Debug.Log("Log file not found");
                return;
            }
            File.WriteAllLines(logFilePath, logMessages);
            Debug.Log($"Logs exported to: {logFilePath}");
        }

        [ConsoleCommand("cs_clear_loggs_txt")]
        [ContextMenu("Clear Logs")]
        public void ClearLogs()
        {
            logMessages.Clear();
            logFilePath = System.IO.Path.Combine(Application.persistentDataPath, "LogCapture.txt");
            if(logFilePath == null || !File.Exists(logFilePath))
            {
                Debug.Log("Log file not found");
                return;
            }
            File.Delete(logFilePath);
        }

        [ConsoleCommand("cs_open_loggs_txt")]
        public void OpenLogFile()
        {
            logFilePath = System.IO.Path.Combine(Application.persistentDataPath, "LogCapture.txt");
            if(logFilePath == null || !File.Exists(logFilePath))
            {
                Debug.Log("Log file not found");
                return;
            }
            System.Diagnostics.Process.Start(logFilePath);
        }

        public string GetAllLog => string.Join("\n", logMessages);
    }
}