using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GestorMaestro.Escuela.MaestrosRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GestorMaestro.Escuela.MaestrosRow;

namespace GestorMaestro.Escuela;

public interface IMaestrosSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MaestrosSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMaestrosSaveHandler
{
    public MaestrosSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}