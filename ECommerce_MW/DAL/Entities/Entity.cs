using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class Entity
    {
        #region Properties
        [Key]//Indica la PK de la entidad
        [Required]//Indica que no puede ser nulo
        public Guid Id { get; set; }
        [Display(Name = "Creation date")]
        public DateTime? CreatedDate { get; set; }//El simbolo "?" indica que el campo puede ser nulo
        [Display(Name = "Modification date")]
        public DateTime? ModifiedDate { get; set;}
        #endregion
    }
}
