using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GestorMaestro.Escuela.SexoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GestorMaestro.Escuela.SexoRow;

namespace GestorMaestro.Escuela;

public interface ISexoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SexoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISexoSaveHandler
{
    public SexoSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}