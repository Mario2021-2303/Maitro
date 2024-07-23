using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GestorMaestro;

public partial class MateriaListFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "GestorMaestro.MateriaListFormatter";

    public MateriaListFormatterAttribute()
        : base(Key)
    {
    }
}