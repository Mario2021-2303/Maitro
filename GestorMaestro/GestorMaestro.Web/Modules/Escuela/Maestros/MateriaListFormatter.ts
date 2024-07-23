import { Decorators, Formatter, Lookup } from "@serenity-is/corelib";
import { FormatterContext } from "@serenity-is/sleekgrid";
import { MateriasRow } from "@/ServerTypes/Escuela/MateriasRow";

let lookup: Lookup<MateriasRow>;
let promise: Promise<Lookup<MateriasRow>>;

@Decorators.registerFormatter('GestorMaestro.MateriaListFormatter')
export class MateriaListFormatter implements Formatter {

    format(ctx: FormatterContext) {

        let idList = ctx.value as number[];
        if (!idList || !idList.length)
            return "";

        let byId = lookup?.itemById;
        if (byId) {
            return idList.map(x => {
                var z = byId[x];
                return ctx.escape(z == null ? x.toString() : z.NombreMateria);
            }).join(", ");
        }

        promise ??= MateriasRow.getLookupAsync().then(l => {
            lookup = l;
            try {
                ctx.grid?.invalidate();
            }
            finally {
                lookup = null;
                promise = null;
            }
        }).catch(() => promise = null);

        return `<i class="fa fa-spinner"></i>`;
    }
}
