﻿using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GestorMaestro.Administration.LanguageRow>;
using MyRow = GestorMaestro.Administration.LanguageRow;


namespace GestorMaestro.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}