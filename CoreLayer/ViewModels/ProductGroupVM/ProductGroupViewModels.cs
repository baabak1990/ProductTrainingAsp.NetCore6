using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.ViewModels.ProductGroupVM
{
   public class IIndexProductGroupVm
    {

        public byte Id { get; set; }
        [Display(Name ="عنوان دوره")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(100)]
        public string Title { get; set; }
        public byte? PartentId { get; set; }
    }
}
