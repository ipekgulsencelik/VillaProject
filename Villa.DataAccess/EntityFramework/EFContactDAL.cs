using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
	public class EFContactDAL : GenericRepository<Contact>, IContactDAL
	{
		public EFContactDAL(VillaContext context) : base(context)
		{
		}
	}
}
