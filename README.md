# EAutoSave

EAutoSave is a Unity Editor extension that provides automatic saving for selected objects within the Unity Editor. This tool is especially useful for assets that do not support Unity's built-in auto-save functionality, like animation clips or Animator setups.

![EAutoSave Window](/EAutoSave.png)

## Features

- **AutoSave Toggle**: Easily enable or disable auto-saving for selected assets.
- **Customizable Interval**: Set the auto-save interval according to your needs.
- **Asset Awareness**: AutoSave only affects currently selected objects, ensuring that only relevant assets are saved.

## Installation

1. Clone or download the `EAutoSave` folder into your Unity project's `Assets/Editor` directory.

## Usage

### Enabling AutoSave
Toggle AutoSave via the toolbar button in the Scene view. When enabled, the selected objects are periodically saved based on the specified interval.

### Adjusting Save Interval
Open the `AutoSave Settings` window by navigating to `Escripts > AutoSave Settings` in Unity's main menu. Here, you can adjust the save interval (in seconds).

### Notifications
AutoSave provides notifications in the console every time an asset is saved, allowing you to keep track of changes.
