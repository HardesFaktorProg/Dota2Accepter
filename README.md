# Dota2Accepter

Dota2Accepter is a small Windows Forms automation utility built with C# and .NET 6.

## About

The project demonstrates screen pixel color detection and mouse input simulation on Windows. It was originally created as a helper tool for detecting a specific game screen state and automatically clicking the center of the screen.

## Features

- Windows Forms interface
- Screen capture
- Center pixel RGB detection
- Mouse click simulation through WinAPI
- Background scanning loop
- Simple enable / disable control

## Technologies

- C#
- .NET 6
- Windows Forms
- WinAPI / user32.dll
- System.Drawing
- Multithreading basics

## Current status

Prototype / beta version.

## Planned improvements

- Improve thread safety
- Replace raw Thread usage with async/Task or cancellation tokens
- Add configurable target color
- Add configurable scan interval
- Add better error handling
- Add screenshots

## How to run

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build the project.
4. Run the application on Windows.

## Author

Created by HardesFaktorProg.
