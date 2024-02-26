using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
	public class CounterManager : GenericManager<Counter>, ICounterService
	{
		public CounterManager(IGenericDAL<Counter> genericDAL) : base(genericDAL)
		{
		}
	}
}