OSK DevConsole

OSK DevConsole is a debugging tool for Unity that allows you to easily create a debug interface with buttons and labels to display and modify game parameters, even after the game is built.

🚀 Features

ConsoleCommand: Create ex: [ConsoleCommand("cs_quit")], [ConsoleCommand("cs_info_system")] ....
LabelConsole: Display and modify variable values in the panel.
Command Line: Enter commands like "cs_set_time_scale 60" to change runtime parameters ...
Auto-Generated UI: Console dynamically creates UI elements from references, supporting generics for flexibility.
Category-Based Interface: Organize debug elements into categories for easier management.
Supports Mobile & PC: Open the console with the Tab key or a UI button.

📦 Installation

1. Add Package from GitHub
Open Unity Package Manager (Window → Package Manager) and select Add package from git URL:
https://github.com/O-S-K/Osk-DevConsole.git


🛠️ Usage

1. Activating the DevConsole

Press the ~ key to open the Console.
Or click button devtool

2. Registering 

[ConsoleCommand("cs_set_fps")]
public void SetFPS(int fps)
{
    Application.targetFrameRate = fps;
    Debug.Log("FPS set to: " + fps);
}
[ConsoleCommand("cs_set_time_scale")]
public void SetTimeScale(float timeScale)
{
    Time.timeScale = timeScale;
}
[ConsoleCommand("cs_quit")]
public void SetQuit()
{
    Application.Quit(); 
}
 

3. Manually Entering Commands

Type into the console:
cs_set_fps 60, cs_set_time_scale = 2, cs_quit .... 

📝 Notes

Supports Unity 2020.3 and later.
Does not affect the final build if not activated.

📜 License
MIT License - Free to use and contribute!

❤️ Contributions
If you want to contribute or report issues, create an issue or pull request on GitHub.

📧 Contact  
Email: gamecoding1999@gmail.com
Facebook: OSK Framework
