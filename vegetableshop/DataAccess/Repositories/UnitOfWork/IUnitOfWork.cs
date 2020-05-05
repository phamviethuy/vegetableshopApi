using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vegetableshop.DataAccess.Repositories
{
   public interface IUnitOfWork:IDisposable
    {
        public IUserRepo UserRepo { get; }
        Task<int> SaveAsync();
        int Save();
    }
}
