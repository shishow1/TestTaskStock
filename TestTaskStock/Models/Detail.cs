using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTaskStock.Models
{
	public class Detail
	{
		[Key]
		public int DetailID { get; set; }

		[Display(Name = "Код")]
		[Required(ErrorMessage = "Не указан код")]
		public int NomCode { get; set; }

		[Display(Name = "Название")]
		[Required(ErrorMessage = "Не указано название")]
		public string Name { get; set; }

		[Display(Name = "Количество")]
		public int Qty { get; set; }

		[Display(Name = "Кладовщик")]
		[Required(ErrorMessage = "Не указан кладовщик")]
		public int StockmanID { get; set; }

		public virtual Stockman Stockman { get; set; }

		[Display(Name = "Дата создания")]
		[Required(ErrorMessage = "Не указана дата создания")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
		public DateTime CreateDate { get; set; }

		[Display(Name = "Дата удаления")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
		public DateTime Deletedate { get; set; }

	}
}