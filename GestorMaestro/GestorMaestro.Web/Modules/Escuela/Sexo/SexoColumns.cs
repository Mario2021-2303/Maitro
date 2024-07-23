using Serenity.ComponentModel;
using System.ComponentModel;

namespace GestorMaestro.Escuela.Columns;

[ColumnsScript("Escuela.Sexo")]
[BasedOnRow(typeof(SexoRow), CheckNames = true)]
public class SexoColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdSexo { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
}