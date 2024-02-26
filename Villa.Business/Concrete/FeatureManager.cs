﻿using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
	public class FeatureManager : GenericManager<Feature>, IFeatureService
	{
		public FeatureManager(IGenericDAL<Feature> genericDAL) : base(genericDAL)
		{
		}
	}
}
