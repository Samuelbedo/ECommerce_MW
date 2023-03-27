using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class Country : Entity
    {
        #region Properties
        [Display(Name = "Pais")]//Como quiero mostrar esta propiedad a nivel de interfaz grafica de usuario
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]//Indica la cantidad de letras que puede tener un campo (Entre mas espacio abarque, mas espacio de memoria)
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]//ErrorMessage lanza un mensaje de error cuando el dataNotation inicial no se cumple
        public string Name { get; set; }
        #endregion

        public ICollection<State> States { get; set; } //Un pais tiene n estados

        public int StateNumber => States == null ? 0 : States.Count;
        /*lleva la cuenta los estados que hay en el ICollection, hay un if ternario que te asegura que no este nula
         * ya que no se puede llevar cuenta de algo nulo*/
    }


}
