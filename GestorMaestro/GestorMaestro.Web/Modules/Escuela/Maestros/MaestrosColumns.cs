using MovieTutorial;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace GestorMaestro.Escuela.Columns;

[ColumnsScript("Escuela.Maestros")]
[BasedOnRow(typeof(MaestrosRow), CheckNames = true)]
public class MaestrosColumns
{

    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdMaestro { get; set; }
    [EditLink]
    public string Nombre { get; set; }
    public string Apellido { get; set; }
  
    [DisplayName("Sexo")]

    public string IdSexoDescripcion { get; set; }
    public string Cedula { get; set; }
    
    [Width(500), MateriaListFormatter, QuickFilter ]
    [DisplayName("Materias")]

    public List<int> MateriaList { get; set; }

   

}