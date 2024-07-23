using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GestorMaestro.Escuela.MaestrosRow>;
using MyRow = GestorMaestro.Escuela.MaestrosRow;

namespace GestorMaestro.Escuela;

public interface IMaestrosRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class MaestrosRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMaestrosRetrieveHandler
{
    public MaestrosRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}