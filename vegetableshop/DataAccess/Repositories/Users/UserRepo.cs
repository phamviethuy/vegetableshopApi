using vegetableshop.DataAccess.Entities;

namespace vegetableshop.DataAccess.Repositories
{
    public class UserRepo:BaseRepo<Users>,IUserRepo
    {
        private readonly vegetableshopContext _context;
        public UserRepo(vegetableshopContext context):base(context)
        {
            _context = context;
        }
    }
}
