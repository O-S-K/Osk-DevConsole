# **OSK DevConsole**

The **OSK DevConsole** is a debugging tool for Unity that allows developers to create a debug interface with buttons and labels to display and modify game parameters, even after the game is built.

**Version 1.0**

---

## **🚀 Features**

1. **[ConsoleCommand]**: Create custom console commands, e.g., `[ConsoleCommand("cs_quit")]`, `[ConsoleCommand("cs_info_system")]`.
2. **[LabelConsole]**: Display and modify variable values in the panel.
3. **[Command Line]**: Enter commands like `cs_set_time_scale 60` to modify runtime parameters.
4. **[Auto-Generated UI]**: Dynamically creates UI elements from references, supporting generics for flexibility.
5. **[Category-Based Interface]**: Organizes debug elements into categories for better management.
6. **[Multi-Platform Support]**: Works on both Mobile & PC; open the console with the `~` key or a UI button.

---

## **📦 Installation**

### **1. Add Package from GitHub**
- Open **Unity Package Manager** (`Window` → `Package Manager`) and select **Add package from git URL**:
  ```sh
  https://github.com/O-S-K/Osk-DevConsole.git
  ```

---

## **🛠️ Usage**

### **1. Activating the DevConsole**
- Press the `~` key to open the console.
- Or click the **DevTool** button in the UI.

### **2. Registering Commands**

#### **Register a Command**
```csharp
[ConsoleCommand("cs_set_fps")]
public void SetFPS(int fps)
{
    Application.targetFrameRate = fps;
    Debug.Log("FPS set to: " + fps);
}
```
```csharp
[ConsoleCommand("cs_set_time_scale")]
public void SetTimeScale(float timeScale)
{
    Time.timeScale = timeScale;
}
```
```csharp
[ConsoleCommand("cs_quit")]
public void SetQuit()
{
    Application.Quit(); 
}
```

### **3. Manually Entering Commands**

Type into the console:
```sh
cs_set_fps 60
cs_set_time_scale 2
cs_quit
```

---

## **📝 Notes**
- **Supports Unity 2020.3 and later**.
- **Does not affect the final build** if not activated.

---

## **📜 License**
**MIT License** - Free to use and contribute!

---

## **❤️ Contributions**
If you want to contribute or report issues, create an **issue** or **pull request** on [GitHub](https://github.com/O-S-K/Osk-DevConsole).

---

## **📧 Contact**
- **Email**: gamecoding1999@gmail.com  
- **Facebook**: [OSK Framework](https://www.facebook.com/xOskx/)

