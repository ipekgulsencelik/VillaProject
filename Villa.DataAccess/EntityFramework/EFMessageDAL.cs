using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
	public class EFMessageDAL : GenericRepository<Message>, IMessageDAL
	{
		public EFMessageDAL(VillaContext context) : base(context)
		{
		}
	}
}