﻿using Application.Contracts.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
     public class LenderRepository : RepositoryBase<Lender>, ILenderRepository
    {
        public LenderRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Lender>> GetLenderAsync()
        {
            var lenders = await _context.Lenders.ToListAsync();
            return lenders;
        }
    }
}