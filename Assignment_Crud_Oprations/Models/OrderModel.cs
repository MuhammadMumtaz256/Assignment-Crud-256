using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Crud_Oprations.Models
{
    public class OrderModel
    {


        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50,ErrorMessage ="name Should Contain Maximum %0 Characters.")]
        public string name { get; set; }
      
      
        public int price { get; set; }
        [Required]
        public int quantity { get; set; }

        [Required, StringLength(1000, MinimumLength = 5)]
        public string discription { get; set; }


    }
}
