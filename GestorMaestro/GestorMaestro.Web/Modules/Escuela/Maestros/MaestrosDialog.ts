import { MaestrosForm, MaestrosRow, MaestrosService } from '@/ServerTypes/Escuela';
import { Decorators, EntityDialog } from '@serenity-is/corelib';
@Decorators.panel()

@Decorators.registerClass('GestorMaestro.Escuela.MaestrosDialog')
export class MaestrosDialog extends EntityDialog<MaestrosRow, any> {
    protected getFormKey() { return MaestrosForm.formKey; }
    protected getRowDefinition() { return MaestrosRow; }
    protected getService() { return MaestrosService.baseUrl; }

    protected form = new MaestrosForm(this.idPrefix);
}