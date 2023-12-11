using System.Management;

class Program
{
    static void Main()
    {
        string directoryToWatch = @"C:/Your/Path/Here";

        FileSystemWatcher watcher = new FileSystemWatcher(directoryToWatch);
        // watcher.Filter = "*.umap"; // Adjust the filter based on your needs

        watcher.Created += OnFileChanged;
        watcher.Deleted += OnFileChanged;
        watcher.Renamed += OnFileRenamed;

        watcher.EnableRaisingEvents = true;

        Console.WriteLine("File watcher started. Press 'Enter' to exit.");
        Console.ReadLine();
    }

    private static void OnFileChanged(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"File {e.ChangeType}: {e.FullPath} - Process: {GetProcessName(e.FullPath)}");
    }

    private static void OnFileRenamed(object sender, RenamedEventArgs e)
    {
        Console.WriteLine($"File renamed: {e.OldFullPath} to {e.FullPath} - Process: {GetProcessName(e.FullPath)}");
    }

    private static string GetProcessName(string filePath)
    {
        try
        {
            string query = $"SELECT * FROM Win32_Process WHERE ExecutablePath = '{filePath.Replace("\\", "\\\\")}'";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                ManagementObjectCollection processes = searcher.Get();
                foreach (ManagementObject process in processes)
                {
                    return process["Caption"].ToString();
                }
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions as needed
        }

        return "Unknown Process";
    }
}
