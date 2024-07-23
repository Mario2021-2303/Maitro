using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GestorMaestro.Escuela.MaestroMateriaRow>;
using MyRow = GestorMaestro.Escuela.MaestroMateriaRow;

namespace GestorMaestro.Escuela;

public interface IMaestroMateriaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class MaestroMateriaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMaestroMateriaRetrieveHandler
{
    public MaestroMateriaRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}