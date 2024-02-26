﻿using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
	public class BannerManager : GenericManager<Banner>, IBannerService
	{
		public BannerManager(IGenericDAL<Banner> genericDAL) : base(genericDAL)
		{
		}
	}
}