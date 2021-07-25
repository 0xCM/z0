//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static XedModels;
    using static core;

    partial class AsmCmdService
    {
        // [CmdOp(".import-xed-tables")]
        // Outcome ImportXedTables(CmdArgs args)
        // {
        //     var result = Outcome.Success;
        //     var path = Sources().Path("xed","xed-tables", FS.Txt);
        //     var parser = Wf.XedTableParser();
        //     using var reader = path.AsciLineReader();
        //     while(reader.Next(out var line))
        //     {
        //         result = XedTableParser.parse(line, out var row);
        //         if(result.Fail)
        //         {
        //             Error(result.Message);
        //             break;
        //         }

        //         Write(string.Format("{0} - {1}", row.LineNumber, row.Kind));
        //     }

        //     return result;
        // }

        [CmdOp(".import-xed-data")]
        Outcome EmitXedTables(CmdArgs args)
        {
            var dst = State.Tables().Subdir(AsmTableScopes.IntelXed);
            dst.Clear();
            Wf.IntelXed().EmitTables(dst);
            return true;
        }


        [CmdOp(".import-cult-data")]
        Outcome ImportCultData(CmdArgs args)
        {

            var result = Wf.CultProcessor().Process();
            return true;
        }


        [CmdOp(".xed-isa")]
        Outcome XedIsa(CmdArgs args)
        {
            var chipName = arg(args,0).Value;
            var symbols = Symbols.index<XedModels.ChipCode>();
            if(!symbols.Lookup(chipName, out var chip))
                return (false, string.Format("Chip '{0}' not found", chipName));

            var xed = Wf.IntelXed();
            var result = xed.LoadChipMap(out var map);
            if(result.Fail)
                return result;

            var kinds = map[chip].ToHashSet();

            var matches = list<XedFormImport>();
            var forms = xed.LoadFormImports();
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

        // .xed-isa CASCADE_LAKE
    }
}