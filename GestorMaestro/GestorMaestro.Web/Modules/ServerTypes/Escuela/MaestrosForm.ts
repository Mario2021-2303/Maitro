import { StringEditor, ServiceLookupEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface MaestrosForm {
    Nombre: StringEditor;
    Apellido: StringEditor;
    IdSexo: ServiceLookupEditor;
    Cedula: StringEditor;
    MateriaList: LookupEditor;
}

export class MaestrosForm extends PrefixedContext {
    static readonly formKey = 'Escuela.Maestros';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MaestrosForm.init)  {
            MaestrosForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = LookupEditor;

            initFormType(MaestrosForm, [
                'Nombre', w0,
                'Apellido', w0,
                'IdSexo', w1,
                'Cedula', w0,
                'MateriaList', w2
            ]);
        }
    }
}