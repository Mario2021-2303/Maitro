using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GestorMaestro.Escuela;

[ConnectionKey("Default"), Module("Escuela"), TableName("Maestro")]
[DisplayName("Maestros"), InstanceName("Maestros")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class MaestrosRow : Row<MaestrosRow.RowFields>, IIdRow, INameRow
{
    const string jIdSexo = nameof(jIdSexo);
    const string jIdMateria = nameof(jIdMateria);

    [DisplayName("Id Estudiante"), Column("idMaestro"), Identity, IdProperty]
    public int? IdMaestro { get => fields.IdMaestro[this]; set => fields.IdMaestro[this] = value; }

    [DisplayName("Nombre"), Size(100), NotNull, QuickSearch, NameProperty]
    public string Nombre { get => fields.Nombre[this]; set => fields.Nombre[this] = value; }

    [DisplayName("Apellido"), Size(100), NotNull]
    public string Apellido { get => fields.Apellido[this]; set => fields.Apellido[this] = value; }

   

    [DisplayName("Id Sexo"), Column("idSexo"), ForeignKey(typeof(SexoRow)), LeftJoin(jIdSexo), TextualField(nameof(IdSexoDescripcion))]
    [ServiceLookupEditor(typeof(SexoRow))]
    public int? IdSexo { get => fields.IdSexo[this]; set => fields.IdSexo[this] = value; }

    [DisplayName("Cedula"), Size(20), NotNull]
    public string Cedula { get => fields.Cedula[this]; set => fields.Cedula[this] = value; }

    

    [DisplayName("Id Sexo Descripcion"), Origin(jIdSexo, nameof(SexoRow.Descripcion))]
    public string IdSexoDescripcion { get => fields.IdSexoDescripcion[this]; set => fields.IdSexoDescripcion[this] = value; }

    

    [LookupEditor(typeof(MateriasRow), Multiple = true)]
    [QuickSearch]
    
    [LinkingSetRelation(typeof(MaestroMateriaRow), nameof(MaestroMateriaRow.IdMaestro), nameof(MaestroMateriaRow.IdMateria))]
    public List<int> MateriaList { get => fields.MateriaList[this]; set => fields.MateriaList[this] = value; }



   


    public class RowFields : RowFieldsBase
    {
        public Int32Field IdMaestro;
        public StringField Nombre;
        public StringField Apellido;
        public Int32Field IdSexo;
        public StringField Cedula;
        public ListField<int> MateriaList;
        public StringField IdSexoDescripcion;
        


    }
}