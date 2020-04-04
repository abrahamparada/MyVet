using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Pet
    {

        public int Id { get; set; }

        /*[Display(Name = "Service Type")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Required(ErrorMessage = "The {0} is mandatory")]
        public string Name { get; set; }*/

        [Display(Name = "Name")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Required(ErrorMessage = "The {0} is mandatory")]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Race")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters")]
        public string Race { get; set; }

        [Display(Name = "Born")]
      
        [Required(ErrorMessage = "The {0} is mandatory")]
      //  [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }

        [MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters")]
        public string Remarks { get; set; }

        //TODO Replace the correct URL for the image

        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://TDB.azurewebsites.net{ImageUrl.Substring(1)}";

        [Display(Name = "Born")]
       // [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime BornLocal => Born.ToLocalTime();

        public PetType PetType { get; set; }

        public Owner Owner { get; set; }

        public ICollection<History> Histories { get; set; }
        public ICollection<Agenda> Agendas { get; set; }


    }
}
