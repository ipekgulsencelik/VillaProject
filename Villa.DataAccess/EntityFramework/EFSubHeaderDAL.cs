using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
    public class EFSubHeaderDAL : GenericRepository<SubHeader>, ISubHeaderDAL
    {
        public EFSubHeaderDAL(VillaContext context) : base(context)
        {
        }
    }
}