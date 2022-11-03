using Facturacion.Models.Attributes;
using Facturacion.Services.Interfaces;

namespace Facturacion.Services.Implementation;

[InjectAsTransient]
public class HomeService : IHomeService
{
    public async Task<string> Demo()
    {
        return await Task.FromResult("Demo From HomeService");
    }
}
