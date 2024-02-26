using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
	public class FrequentlyQuestionManager : GenericManager<FrequentlyQuestion>, IFrequentlyQuestionService
	{
		public FrequentlyQuestionManager(IGenericDAL<FrequentlyQuestion> genericDAL) : base(genericDAL)
		{
		}
	}
}