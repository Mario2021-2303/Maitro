using Serenity.ComponentModel;
using System.ComponentModel;

namespace GestorMaestro.Escuela.Columns;

[ColumnsScript("Escuela.Materias")]
[BasedOnRow(typeof(MateriasRow), CheckNames = true)]
public class MateriasColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdMateria { get; set; }
    [EditLink]
    public string NombreMateria { get; set; }
}