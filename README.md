Nexus Browser: Chromium-Based Web Browser

A simple C# Windows Forms application that serves as a functional web browser, utilizing the modern Chromium engine for high-performance web rendering.

Features:
Chromium Engine: Powered by Microsoft Edge WebView2 for modern web compatibility.

Smart Address Bar: Supports both direct URL navigation and automatic Google searching.

Navigation Controls: Functional Back, Forward, and Go buttons for easy browsing.

Dynamic Resizing: The browser layout and address bar resize automatically with the window.

Title Sync: The application window title updates to match the current website's name.

How it works:
The app integrates the Microsoft.Web.WebView2 SDK. It initializes an asynchronous browser environment and handles UI events like key presses (Enter) and button clicks to manage the navigation lifecycle of the web engine.

Tech used
C#

Windows Forms

.NET 9.0

Microsoft Edge WebView2 (Chromium)

How to run
Install .NET 9.0 SDK

Open the project folder in your terminal

Run: dotnet run
