using SystemForge.Services.FileService;

namespace SystemForge.ViewModels;

public class FilesViewModel : BaseViewModel
{
    public string CurrentPath { get; set; } = "C:\\";
    
    private readonly FileService _fileService;

    public FilesViewModel(FileService fileService)
    {
        _fileService = fileService;
    }
}
