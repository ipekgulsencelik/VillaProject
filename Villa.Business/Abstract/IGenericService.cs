using MongoDB.Bson;
using System.Linq.Expressions;

namespace Villa.Business.Abstract
{
	public interface IGenericService<T> where T : class
	{
		Task TCreateAsync(T entity);
		Task TDeleteAsync(ObjectId id);
		Task TUpdateAsync(T entity);
		Task<T> TGetByIdAsync(ObjectId id);
		Task<List<T>> TGetListAsync();
		Task<int> TCountAsync();
		Task<List<T>> TGetFilteredListAsync(Expression<Func<T, bool>> predicate);
	}
}