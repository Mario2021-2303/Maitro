using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GestorMaestro.Escuela;

[ConnectionKey("Default"), Module("Escuela"), TableName("MaestroMateria")]
[DisplayName("Maestro Materia"), InstanceName("Maestro Materia")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class MaestroMateriaRow : Row<MaestroMateriaRow.RowFields>, IIdRow
{
    const string jIdMaestro = nameof(jIdMaestro);
    const string jIdMateria = nameof(jIdMateria);

    [DisplayName("Id Maestro"), Column("IDMaestro"), PrimaryKey, NotNull, ForeignKey(typeof(MaestrosRow)), LeftJoin(jIdMaestro), IdProperty]
    [TextualField(nameof(IdMaestroNombre)), ServiceLookupEditor(typeof(MaestrosRow), Service = "Escuela/Maestros/List")]
    public int? IdMaestro { get => fields.IdMaestro[this]; set => fields.IdMaestro[this] = value; }

    [DisplayName("Id Materia"), Column("IDMateria"), PrimaryKey, NotNull, ForeignKey(typeof(MateriasRow)), LeftJoin(jIdMateria)]
    [TextualField(nameof(IdMateriaNombreMateria)), ServiceLookupEditor(typeof(MateriasRow), Service = "Escuela/Materias/List")]
    public int? IdMateria { get => fields.IdMateria[this]; set => fields.IdMateria[this] = value; }

    [DisplayName("Id Maestro Nombre"), Origin(jIdMaestro, nameof(MaestrosRow.Nombre))]
    public string IdMaestroNombre { get => fields.IdMaestroNombre[this]; set => fields.IdMaestroNombre[this] = value; }

    [DisplayName("Id Materia Nombre Materia"), Origin(jIdMateria, nameof(MateriasRow.NombreMateria))]
    public string IdMateriaNombreMateria { get => fields.IdMateriaNombreMateria[this]; set => fields.IdMateriaNombreMateria[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdMaestro;
        public Int32Field IdMateria;

        public StringField IdMaestroNombre;
        public StringField IdMateriaNombreMateria;
    }
}