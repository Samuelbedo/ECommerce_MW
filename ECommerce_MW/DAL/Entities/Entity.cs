using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class Entity
    {
        #region Properties
        [Key]//Indica la PK de la entidad
        [Required]//Indica que no puede ser nulo
        public Guid Id { get; set; } 
        public DateTime? CreatedDate { get; set; }//El simbolo "?" indica que el campo puede ser nulo
        public DateTime? ModifiedDate { get; set;}
        #endregion
    }
}
