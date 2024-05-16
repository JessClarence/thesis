﻿using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.IRepositories;
using InfastructureLayer.Data;
using DomainLayer.Models;
using InfastructureLayer.Repositories;

namespace InfastructureLayer.Repositories
{
	public class MeatInspectionReceivingReportRepository : Repository<MeatInspectionReceivingReport>, IMeatInspectionReceivingReportRepository
	{
		private readonly AppDbContext _context;

		public MeatInspectionReceivingReportRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}
		public void Update(MeatInspectionReceivingReport entity)
		{
			_context.Update(entity);
		}
	}
}