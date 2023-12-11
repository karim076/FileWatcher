# FileWatcher

FileWatcher is a C# program that enables real-time monitoring of file activity in a specified directory. Keep track of changes, additions, and deletions effortlessly with this lightweight and efficient tool.

## Features

- Real-time monitoring of file and directory activities.
- Simple configuration for choosing the target file path.
- Receive notifications for file creation, modification, and deletion.

## How It Works

FileWatcher utilizes the FileSystemWatcher class in C# to provide a seamless mechanism for monitoring file system events. By subscribing to events such as Created, Changed, and Deleted, it ensures timely notifications for any activity in the specified directory.

## Getting Started

### Prerequisites

- .NET Core SDK [Download here](https://dotnet.microsoft.com/download)
- An integrated development environment (IDE) such as Visual Studio or Visual Studio Code.

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/FileWatcher.git
   cd FileWatcher
2. Open the project in your preferred IDE.

3. Build the project to restore dependencies.

4. Run the application, providing the absolute path of the directory to monitor as a command-line argument.

## Contribution
Feel free to customize this template further based on your specific project details and preferences.
