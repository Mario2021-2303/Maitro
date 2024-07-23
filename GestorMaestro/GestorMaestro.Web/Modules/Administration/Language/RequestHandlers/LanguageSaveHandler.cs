using MyRequest = Serenity.Services.SaveRequest<GestorMaestro.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GestorMaestro.Administration.LanguageRow;


namespace GestorMaestro.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}