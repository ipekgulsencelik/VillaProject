using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
	public class EFCounterDAL : GenericRepository<Counter>, ICounterDAL
	{
		public EFCounterDAL(VillaContext context) : base(context)
		{
		}
	}
}