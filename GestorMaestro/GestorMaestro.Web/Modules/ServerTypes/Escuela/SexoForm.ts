import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SexoForm {
    Descripcion: StringEditor;
}

export class SexoForm extends PrefixedContext {
    static readonly formKey = 'Escuela.Sexo';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SexoForm.init)  {
            SexoForm.init = true;

            var w0 = StringEditor;

            initFormType(SexoForm, [
                'Descripcion', w0
            ]);
        }
    }
}