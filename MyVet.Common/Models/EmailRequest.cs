using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVet.Common.Models
{
        public class EmailRequest
    {
        [Required]   //Hace el campo requerido
        [EmailAddress]  // Valida formato Email
        public string Email { get; set; }


    }

}
