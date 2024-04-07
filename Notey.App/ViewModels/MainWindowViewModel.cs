using Notey.App.Models;
using Notey.App.Models.Repositories;
using Notey.App.Services;

namespace Notey.App.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly IPagesRepo _pagesRepo;
    public Page Page { get; set; }
    public Page Page1 { get; set; }
    public Page Page2 { get; set; }

    public MainWindowViewModel(IPagesRepo pagesRepo, AppState appState)
    {
        _pagesRepo = pagesRepo;
        //GetPageData(appState.CurrentPageNumber);
    }
    public string Greeting => "Welcome to Avalonia!";

    public async void GetPagesData()
    {
        var pagesData = await _pagesRepo.GetPages();
        //Page page1 = new Page() { Id = pagesData[0].Id, Title = pagesData[0].Title, Body = pagesData[0].Body };
        
    }

    public async void GetPageData(int pagenumber)
    {
        Page = await _pagesRepo.GetPage(pagenumber);
    }
    
}