//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;
    using static WsAtoms;

    partial class AsmCmdService
    {
        Outcome EmitXedIsa(string cname)
        {
            var result = Outcome.Success;
            var symbols = Xed.ChipCodes();
            if(!symbols.Lookup(cname, out var code))
                return (false, string.Format("Chip '{0}' not found", cname));

            result = Xed.LoadChipMap(out var map);
            if(result.Fail)
                return result;

            var kinds = map[code].ToHashSet();
            var matches = list<XedFormImport>();
            var forms = Xed.LoadForms();
            var count = forms.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var form = ref skip(forms,i);
                if(kinds.Contains(form.IsaKind))
                    matches.Add(form);
            }

            var dst = Ws.Tables().TablePath<XedFormImport>(intelxed, code.Kind.ToString());
            var formatter = Tables.formatter<XedFormImport>();
            var rows = Tables.emit(matches.ViewDeposited(), XedFormImport.RenderWidths, dst);
            Write(EmittedQueryResults.Format(rows,dst));
            return result;
        }
    }
}