using System.Collections.Generic;
using System.Threading.Tasks;

namespace Notey.App.Models.Repositories;

public interface IPagesRepo
{
    public Task<List<Page>> GetPages();
    public Task<Page> GetPage(int pageid);
    public Task AddPage();
    public Task ClearPage();
    public Task RemovePage();
}