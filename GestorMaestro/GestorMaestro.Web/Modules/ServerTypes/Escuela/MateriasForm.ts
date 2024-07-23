import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface MateriasForm {
    NombreMateria: StringEditor;
}

export class MateriasForm extends PrefixedContext {
    static readonly formKey = 'Escuela.Materias';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MateriasForm.init)  {
            MateriasForm.init = true;

            var w0 = StringEditor;

            initFormType(MateriasForm, [
                'NombreMateria', w0
            ]);
        }
    }
}