using PocketBookCore.IRepositories;

namespace PocketBook.Core.IConfiguration;

public interface IUnitOfWork
{
    IUserRepository Users {get; }

    Task CompleteAsync();
}
