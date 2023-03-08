using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class Country : Entity
    {
        #region Properties
        [Display(Name = "Pais")]//Como quiero mostrar esta propiedad a nivel de initerfaz grafica de usuario
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]//Indica la cantidad de letras que puede tener un campo (Entre mas espacio abarque, mas espacio de memoria)
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]//ErrorMessage lanza un mensaje de error cuando el dataNotation inicial no se cumple
        public string Name { get; set; }

        #endregion
    }
}
