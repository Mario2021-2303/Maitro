using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GestorMaestro;

public partial class MaestrosFormartterAttribute : CustomFormatterAttribute
{
    public const string Key = "GestorMaestro.MaestrosFormartter";

    public MaestrosFormartterAttribute()
        : base(Key)
    {
    }
}