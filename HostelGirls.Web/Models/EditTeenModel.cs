using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelGirls.Web.Models
{
    public class EditTeenModel
    {
       
        public int TeenId { get; set; }
        [Required]
        public int Number { get; set; }
        
        public string Id { get; set; }

        [Required(ErrorMessage = "FirstName is mandatory")]
        [MinLength(2)]
        public string Name { get; set; }        
        public string Img { get; set; }

        public string ImgName { get; set; }
    }
}
