using DomainLayer.Entities.Baseentities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities.ProductGroups
{
    public class ProductGroup : BaseEntity<byte>, IAudiotable
    {
        #region Properties
        [Display(Name ="عنوان دوره")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(255)]
        public string Title { get; set; }
        public byte? PartentId { get; set; }
        #endregion
        #region
        [ForeignKey(nameof(PartentId))]
        public ICollection<ProductGroup> productGroups { get; set; }
        #endregion
        #region Generals
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        #endregion
    }
}
