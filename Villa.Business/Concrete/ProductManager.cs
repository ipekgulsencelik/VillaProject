using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
	public class ProductManager : GenericManager<Product>, IProductService
	{
		public ProductManager(IGenericDAL<Product> genericDAL) : base(genericDAL)
		{
		}
	}
}