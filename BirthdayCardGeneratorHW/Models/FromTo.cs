using System;
using System.ComponentModel.DataAnnotations;
namespace BirthdayCardGenerator.Models
{
	public class FromTo
	{
        [Required(ErrorMessage = "Please enter From")]
        public string From { get; set; }
        [Required(ErrorMessage = "Please enter To")]
        public string To { get; set; }
        [Required(ErrorMessage = "Please enter Message")]
        public string Message { get; set; }
        //public string WillAttend { get; set; }
    }
}

