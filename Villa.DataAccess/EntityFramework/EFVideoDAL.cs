using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
	public class EFVideoDAL : GenericRepository<Video>, IVideoDAL
	{
		public EFVideoDAL(VillaContext context) : base(context)
		{
		}
	}
}