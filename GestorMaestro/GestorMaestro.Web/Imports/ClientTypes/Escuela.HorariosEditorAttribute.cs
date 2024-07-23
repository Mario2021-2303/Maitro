using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GestorMaestro.Escuela;

public partial class HorariosEditorAttribute : CustomEditorAttribute
{
    public const string Key = "GestorMaestro.Escuela.HorariosEditor";

    public HorariosEditorAttribute()
        : base(Key)
    {
    }
}