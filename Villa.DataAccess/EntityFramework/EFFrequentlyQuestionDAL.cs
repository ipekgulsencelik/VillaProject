using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
	public class EFFrequentlyQuestionDAL : GenericRepository<FrequentlyQuestion>, IFrequentlyQuestionDAL
	{
		public EFFrequentlyQuestionDAL(VillaContext context) : base(context)
		{
		}
	}
}