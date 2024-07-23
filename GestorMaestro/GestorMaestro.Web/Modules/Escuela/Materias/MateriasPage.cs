using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GestorMaestro.Escuela.Pages;

[PageAuthorize(typeof(MateriasRow))]
public class MateriasPage : Controller
{
    [Route("Escuela/Materias")]
    public ActionResult Index()
    {
        return this.GridPage("@/Escuela/Materias/MateriasPage",
            MateriasRow.Fields.PageTitle());
    }
}