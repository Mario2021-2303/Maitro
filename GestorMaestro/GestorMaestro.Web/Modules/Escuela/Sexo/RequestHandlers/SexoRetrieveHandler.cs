using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GestorMaestro.Escuela.SexoRow>;
using MyRow = GestorMaestro.Escuela.SexoRow;

namespace GestorMaestro.Escuela;

public interface ISexoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SexoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISexoRetrieveHandler
{
    public SexoRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}