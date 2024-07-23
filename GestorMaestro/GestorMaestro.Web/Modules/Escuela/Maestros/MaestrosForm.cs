using MovieTutorial;
using MovieTutorial.MovieDB;
using Serenity.ComponentModel;

namespace GestorMaestro.Escuela.Forms;

[FormScript("Escuela.Maestros")]
[BasedOnRow(typeof(MaestrosRow), CheckNames = true)]
public class MaestrosForm
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    [DisplayName("Sexo")]
     public int IdSexo { get; set; }
    
    public string Cedula { get; set; }
    [DisplayName("Materias")]

    public List<int> MateriaList { get; set; }
   
   
   
}