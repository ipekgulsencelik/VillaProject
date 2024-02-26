using Villa.Business.Abstract;
using Villa.Business.Concrete;
using Villa.DataAccess.Abstract;
using Villa.DataAccess.EntityFramework;
using Villa.DataAccess.Repositories;

namespace Villa.WebUI.Extensions
{
	public static class ServiceExtensions
	{
		public static void AddServiceExtensions(this IServiceCollection Services)
		{		
			Services.AddScoped<IBannerDAL, EFBannerDAL>();
			Services.AddScoped<IBannerService, BannerManager>();

			Services.AddScoped<IContactDAL, EFContactDAL>();
			Services.AddScoped<IContactService, ContactManager>();

			Services.AddScoped<ICounterDAL, EFCounterDAL>();
			Services.AddScoped<ICounterService, CounterManager>();

			Services.AddScoped<IDealDAL, EFDealDAL>();
			Services.AddScoped<IDealService, DealManager>();

			Services.AddScoped<IFeatureDAL, EFFeatureDAL>();
			Services.AddScoped<IFeatureService, FeatureManager>();

			Services.AddScoped<IFrequentlyQuestionDAL, EFFrequentlyQuestionDAL>();
			Services.AddScoped<IFrequentlyQuestionService, FrequentlyQuestionManager>();

			Services.AddScoped<IMessageDAL, EFMessageDAL>();
			Services.AddScoped<IMessageService, MessageManager>();

			Services.AddScoped<IProductDAL, EFProductDAL>();
			Services.AddScoped<IProductService, ProductManager>();

			Services.AddScoped<IVideoDAL, EFVideoDAL>();
			Services.AddScoped<IVideoService, VideoManager>();

			Services.AddScoped(typeof(IGenericDAL<>), typeof(GenericRepository<>));
			Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
		}
	}
}