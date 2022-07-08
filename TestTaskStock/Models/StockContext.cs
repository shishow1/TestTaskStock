using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestTaskStock.Models
{
	public class StockContext : DbContext
	{
		public DbSet<Detail> Details { get; set; }
		public DbSet<Stockman> Stockmans { get; set; }
	}
}