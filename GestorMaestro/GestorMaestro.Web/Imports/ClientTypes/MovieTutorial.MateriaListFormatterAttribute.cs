using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieTutorial;

public partial class MateriaListFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "MovieTutorial.MateriaListFormatter";

    public MateriaListFormatterAttribute()
        : base(Key)
    {
    }
}