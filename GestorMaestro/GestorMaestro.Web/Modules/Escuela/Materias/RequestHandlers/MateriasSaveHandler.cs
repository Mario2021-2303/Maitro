using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GestorMaestro.Escuela.MateriasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GestorMaestro.Escuela.MateriasRow;

namespace GestorMaestro.Escuela;

public interface IMateriasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MateriasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMateriasSaveHandler
{
    public MateriasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}