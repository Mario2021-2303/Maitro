using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GestorMaestro.Escuela.MaestroMateriaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GestorMaestro.Escuela.MaestroMateriaRow;

namespace GestorMaestro.Escuela;

public interface IMaestroMateriaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MaestroMateriaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMaestroMateriaSaveHandler
{
    public MaestroMateriaSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}