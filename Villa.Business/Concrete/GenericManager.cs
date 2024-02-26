﻿using MongoDB.Bson;
using System.Linq.Expressions;
using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;

namespace Villa.Business.Concrete
{
	public class GenericManager<T> : IGenericService<T> where T : class
	{
		private readonly IGenericDAL<T> _genericDAL;

		public GenericManager(IGenericDAL<T> genericDAL)
		{
			_genericDAL = genericDAL;
		}

		public async Task<int> TCountAsync()
		{
			return await _genericDAL.CountAsync();
		}

		public async Task TCreateAsync(T entity)
		{
			await _genericDAL.CreateAsync(entity);
		}

		public async Task TDeleteAsync(ObjectId id)
		{
			await _genericDAL.DeleteAsync(id);
		}

		public async Task<T> TGetByIdAsync(ObjectId id)
		{
			return await _genericDAL.GetByIdAsync(id);
		}

		public async Task<List<T>> TGetFilteredListAsync(Expression<Func<T, bool>> predicate)
		{
			return await _genericDAL.GetFilteredListAsync(predicate);
		}

		public async Task<List<T>> TGetListAsync()
		{
			return await _genericDAL.GetListAsync();
		}

		public async Task TUpdateAsync(T entity)
		{
			await _genericDAL.UpdateAsync(entity);
		}
	}
}
