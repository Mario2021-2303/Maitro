using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GestorMaestro.Escuela;

[ConnectionKey("Default"), Module("Escuela"), TableName("Materias")]
[DisplayName("Materias"), InstanceName("Materias")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript]
public sealed class MateriasRow : Row<MateriasRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Materia"), Column("idMateria"), Identity, IdProperty]
    public int? IdMateria { get => fields.IdMateria[this]; set => fields.IdMateria[this] = value; }

    [DisplayName("Nombre Materia"), Size(100), NotNull, QuickSearch, NameProperty]
    public string NombreMateria { get => fields.NombreMateria[this]; set => fields.NombreMateria[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdMateria;
        public StringField NombreMateria;

    }
}