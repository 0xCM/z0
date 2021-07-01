//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;
    using static Typed;

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

        [CmdOp(".emit-modrm-tables")]
        Outcome EmitModRmTables(CmdArgs args)
        {
            const string Pattern = "{0,-3} | {1,-3} | {2,-3} | {3}";
            var header = string.Format(Pattern, "mod", "reg", "r/m", "hex");
            var workspace = Wf.AsmWorkspace();
            var dst = workspace.Table("modrm", FS.Csv);
            var flow = Wf.EmittingFile(dst);
            var counter = 0u;
            using var writer = dst.AsciWriter();
            writer.WriteLine(header);
            for(byte mod=0; mod <4; mod++)
            {
                for(byte reg=0; reg<8; reg++)
                {
                    for(byte rm=0; rm<8; rm++)
                    {
                        var code = math.or(math.sll(mod,6), math.sll(reg,3), rm);
                        var row = string.Format(Pattern,
                            BitRender.format(n2, mod),
                            BitRender.format(n3, reg),
                            BitRender.format(n3, rm),
                            code.FormatHex(specifier:false)
                            );

                        writer.WriteLine(row);
                        counter++;
                    }
                }
            }
            Wf.EmittedFile(flow,counter);
            return true;
        }

        // [CmdOp(".emit-xed-forms")]
        // Outcome ImportXedSummaries(CmdArgs args)
        // {
        //     var parser = XedSummaryParser.create(Wf.EventSink);
        //     var parsed = parser.ParseSummaries();
        //     Status($"Parsed {parsed.Length} summaries");
        //     Wf.IntelXed().EmitFormSummaries(parsed);
        //     return true;
        // }

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

        [CmdOp(".import-cpuid")]
        Outcome ImportCpuid(CmdArgs args)
        {
            return Wf.AsmDataPipes().ImportCpuIdSources();
        }
    }
}