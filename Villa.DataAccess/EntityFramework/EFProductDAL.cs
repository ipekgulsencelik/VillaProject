using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
	public class EFProductDAL : GenericRepository<Product>, IProductDAL
	{
		public EFProductDAL(VillaContext context) : base(context)
		{
		}
	}
}