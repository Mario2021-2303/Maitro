using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GestorMaestro.Escuela.SexoRow>;
using MyRow = GestorMaestro.Escuela.SexoRow;

namespace GestorMaestro.Escuela;

public interface ISexoListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SexoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISexoListHandler
{
    public SexoListHandler(IRequestContext context)
            : base(context)
    {
    }
}