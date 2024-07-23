using Serenity.ComponentModel;

namespace GestorMaestro.Escuela.Forms;

[FormScript("Escuela.Materias")]
[BasedOnRow(typeof(MateriasRow), CheckNames = true)]
public class MateriasForm
{
    public string NombreMateria { get; set; }
}