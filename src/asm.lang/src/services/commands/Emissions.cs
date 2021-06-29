//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".gen-regname-provider")]
        Outcome GenRegNameProvider(CmdArgs args)
        {
            Wf.AsmModelGen().EmitRegNameProvider();
            return true;
        }

        [CmdOp(".regnames-save")]
        Outcome EmitRegNames(CmdArgs args)
        {
            var dst = Db.AppLog("regnames", FS.Cs);
            using var writer = dst.AsciWriter();
            var regs = AsmRegs.list(AsmCodes.GP);
            var bytespan = SpanRes.specify("GpRegNames", recover<RegOp,byte>(regs).ToArray());
            writer.WriteLine(bytespan.Format());
            return true;
        }

        [CmdOp(".emit-cli-headers")]
        Outcome EmitCliHeaders(CmdArgs args)
        {
            var svc = Wf.CliEmitter();
            svc.EmitSectionHeaders(Wf.RuntimeArchive());
            return true;
        }

        [CmdOp(".emit-xed-cat")]
        Outcome EmitXedCatalog(CmdArgs args)
        {
            Wf.IntelXed().EmitCatalog();
            return true;
        }

        [CmdOp(".emit-xed-forms")]
        Outcome EmitXedForms(CmdArgs args)
        {
            var parser = XedSummaryParser.create(Wf.EventSink);
            var parsed = parser.ParseSummaries();
            Status($"Parsed {parsed.Length} summaries");
            Wf.IntelXed().EmitFormSummaries(parsed);
            return true;
        }

        void CheckCpuid()
        {
            // var descriptor = Parts.AsmCases.Assets.CpuIdRows();
            // Utf8.decode(descriptor.ResBytes, out var content);
            // var pipe = Wf.AsmRowPipe();
            // using var reader = content.Reader();
            // var rows = pipe.LoadCpuIdRows(reader);
            // var formatter = rows.RecordFormatter(CpuIdRow.RenderWidths);
            // Wf.Row(formatter.FormatHeader());
            // core.iter(rows, row => Wf.Row(formatter.Format(row)));
        }

        [CmdOp(".cpuid-data")]
        Outcome CpuidData(CmdArgs args)
        {
            //2 space-separated 32-bit hex numbers
            const byte InLength = 2*8 + 1;

            //4 32-bit hex numbers interspersed with spaces
            const byte OutLength = 4*8 + 3;

            const string Imply = " => ";

            var dir = Workspace.Dataset("cpuid");
            var files = dir.Files(FS.Def,true).ToReadOnlySpan();
            var count = files.Length;
            var outcome = Outcome.Success;

            for(var i=0; i<count; i++)
            {
                if(outcome.Fail)
                    break;

                ref readonly var file = ref skip(files,i);
                var chip = file.FolderName;
                var records = list<CpuIdRow>();
                var formatter = Tables.formatter<CpuIdRow>();
                using var reader = file.AsciLineReader();
                while(reader.Next(out var line))
                {
                    if(line.StartsWith(Chars.Hash))
                        continue;

                    var content = line.Content;
                    var index = TextTools.index(content, Imply);
                    if(index != NotFound)
                    {
                        Babble(string.Format("Parsing {0} {1}", chip, line));
                        var row = new CpuIdRow();
                        var input = TextTools.left(content, index);
                        var iargs = input.Split(Chars.Space).ToReadOnlySpan();
                        if(iargs.Length != 2)
                        {
                            outcome = (false, "Line did not split on marker");
                            break;
                        }

                        outcome = DataParser.parse(skip(iargs,0), out row.Leaf);
                        if(outcome.Fail)
                        {
                            outcome = (false, "Failed to parse eax");
                            break;
                        }

                        if(skip(iargs,1).Contains(Chars.Star))
                            row.Subleaf = uint.MaxValue;
                        else
                            outcome = DataParser.parse(skip(iargs,1), out row.Subleaf);

                        if(outcome.Fail)
                        {
                            outcome = (false, "Failed to parse ecx");
                            break;
                        }

                        var output = TextTools.right(content,index);
                        if(output.Length < OutLength)
                        {
                            outcome = (false, "Output length too short");
                            break;
                        }

                        var outvals = TextTools.slice(output, 0, OutLength).Split(Chars.Space).ToReadOnlySpan();
                        if(outvals.Length < 4)
                        {
                            outcome = (false, string.Format("Output count = {0}, expected at least {1}", outvals.Length, OutLength));
                            break;
                        }

                        outcome = DataParser.parse(skip(outvals,0), out row.Eax);
                        outcome = DataParser.parse(skip(outvals,1), out row.Ebx);
                        outcome = DataParser.parse(skip(outvals,2), out row.Ecx);
                        outcome = DataParser.parse(skip(outvals,3), out row.Edx);

                        if(outcome)
                        {
                            records.Add(row);
                        }
                    }
                }
           }

            return outcome;
        }
    }
}