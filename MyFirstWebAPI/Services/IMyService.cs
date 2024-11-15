using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Services
{
    public interface IMyService
    {
        List<Product> GetAll();
    }
}