using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
    public class SubHeaderManager : GenericManager<SubHeader>, ISubHeaderService
    {
        public SubHeaderManager(IGenericDAL<SubHeader> genericDAL) : base(genericDAL)
        {
        }
    }
}