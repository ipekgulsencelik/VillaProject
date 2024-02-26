﻿using MongoDB.Bson;
using System.Linq.Expressions;

namespace Villa.DataAccess.Abstract
{
	public interface IGenericDAL<T> where T : class
	{
		Task CreateAsync(T entity);
		Task DeleteAsync(ObjectId id);
		Task UpdateAsync(T entity);
		Task<T> GetByIdAsync(ObjectId id);
		Task<List<T>> GetListAsync();
		Task<int> CountAsync();
		Task<List<T>> GetFilteredListAsync(Expression<Func<T, bool>> predicate);
	}
}