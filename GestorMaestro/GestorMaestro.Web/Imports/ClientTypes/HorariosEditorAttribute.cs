using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GestorMaestro;

public partial class HorariosEditorAttribute : CustomEditorAttribute
{
    public const string Key = "GestorMaestro.Escuela";

    public HorariosEditorAttribute()
        : base(Key)
    {
    }
}