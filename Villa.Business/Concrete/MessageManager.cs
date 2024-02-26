using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
	public class MessageManager : GenericManager<Message>, IMessageService
	{
		public MessageManager(IGenericDAL<Message> genericDAL) : base(genericDAL)
		{
		}
	}
}