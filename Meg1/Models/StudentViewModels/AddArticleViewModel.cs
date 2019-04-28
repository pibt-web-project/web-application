using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace Meg1.Models.StudentViewModels
{
    public class AddArticleViewModel 
    {
        public string Name { get; set; }

        public int Faculty { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public IFormFile Document { get; set; }

        public IFormFile Image { get; set; }





    }
}
