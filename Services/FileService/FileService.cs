using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SystemForge.Services.FileService;

public class FileService
{
    public IEnumerable<string> GetDrives()
    {
        return DriveInfo.GetDrives()
            .Where(d => d.IsReady)
            .Select(d => d.RootDirectory.FullName);
    }

    public IEnumerable<string> GetDirectories(string path)
    {
        return Directory.GetDirectories(path);
    }

    public IEnumerable<string> GetFiles(string path)
    {
        return Directory.GetFiles(path);
    }
}
