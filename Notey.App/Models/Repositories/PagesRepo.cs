using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Notey.App.Models.Repositories;

class PagesRepo : IPagesRepo
{
    private readonly DataContext _db;

    public PagesRepo(DataContext db)
    {
        _db = db;
    }
    
    public async Task<List<Page>> GetPages()
    {
        return await _db.Pages.ToListAsync();
    }

    public async Task GetPage(int pageid)
    {
        throw new System.NotImplementedException();
    }

    public async Task AddPage()
    {
        throw new System.NotImplementedException();
    }

    public async Task ClearPage()
    {
        throw new System.NotImplementedException();
    }

    public async Task RemovePage()
    {
        throw new System.NotImplementedException();
    }
}