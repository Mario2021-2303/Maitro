using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GestorMaestro.Escuela;

[ConnectionKey("Default"), Module("Escuela"), TableName("Sexo")]
[DisplayName("Sexo"), InstanceName("Sexo")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class SexoRow : Row<SexoRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Sexo"), Column("idSexo"), PrimaryKey, NotNull, IdProperty]
    public int? IdSexo { get => fields.IdSexo[this]; set => fields.IdSexo[this] = value; }

    [DisplayName("Descripcion"), Size(50), NotNull, QuickSearch, NameProperty]
    public string Descripcion { get => fields.Descripcion[this]; set => fields.Descripcion[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdSexo;
        public StringField Descripcion;

    }
}