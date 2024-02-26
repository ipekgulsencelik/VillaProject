using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
	public class EFFeatureDAL : GenericRepository<Feature>, IFeatureDAL
	{
		public EFFeatureDAL(VillaContext context) : base(context)
		{
		}
	}
}