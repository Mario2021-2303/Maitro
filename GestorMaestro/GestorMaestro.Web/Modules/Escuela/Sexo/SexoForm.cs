using Serenity.ComponentModel;

namespace GestorMaestro.Escuela.Forms;

[FormScript("Escuela.Sexo")]
[BasedOnRow(typeof(SexoRow), CheckNames = true)]
public class SexoForm
{
    public string Descripcion { get; set; }
}