//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".xed-isa")]
        Outcome XedIsa(CmdArgs args)
        {
            var chipName = arg(args,0).Value;
            var symbols = Symbols.index<XedModels.ChipCode>();
            if(!symbols.Lookup(chipName, out var chip))
                return (false, string.Format("Chip '{0}' not found", chipName));

            var result = Xed.LoadChipMap(out var map);
            if(result.Fail)
                return result;

            var kinds = map[chip].ToHashSet();

            var matches = list<XedFormImport>();
            var forms = Xed.LoadForms();
            var count = forms.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var form = ref skip(forms,i);
                if(kinds.Contains(form.IsaKind))
                    matches.Add(form);
            }

            var dst = Ws.Output().Table<XedFormImport>("queries", chip.Kind.ToString());
            var formatter = Tables.formatter<XedFormImport>();
            var rows = Tables.emit(matches.ViewDeposited(), XedFormImport.RenderWidths, dst);
            Write(EmittedQueryResults.Format(rows,dst));

            return true;
        }
    }
}