using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
	public class EFBannerDAL : GenericRepository<Banner>, IBannerDAL
	{
		public EFBannerDAL(VillaContext context) : base(context)
		{
		}
	}
}