using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
	public class ContactManager : GenericManager<Contact>, IContactService
	{
		public ContactManager(IGenericDAL<Contact> genericDAL) : base(genericDAL)
		{
		}
	}
}