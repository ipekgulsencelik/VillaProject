using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
	public class EFDealDAL : GenericRepository<Deal>, IDealDAL
	{
		public EFDealDAL(VillaContext context) : base(context)
		{
		}
	}
}