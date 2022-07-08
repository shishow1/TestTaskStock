using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTaskStock.Models
{
	public class Stockman
	{
		[Key]
		[Display(Name = "Кладовщик")]
		public int StockmanID { get; set; }
		[Display(Name = "Кладовщик")]
		[Required(ErrorMessage = "Введите имя")]
		public string FullName { get; set; }

	}
}