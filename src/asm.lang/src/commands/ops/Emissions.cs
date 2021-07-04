//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;
    using static Typed;
    using static AsmCodes;

    partial class AsmCmdService
    {
        [CmdOp(".gen-regname-provider")]
        Outcome GenRegNameProvider(CmdArgs args)
        {
            Wf.AsmModelGen().EmitRegNameProvider();
            return true;
        }

        [CmdOp(".emit-regnames")]
        Outcome EmitRegNames(CmdArgs args)
        {
            var dst = Db.AppLog("regnames", FS.Cs);
            using var writer = dst.AsciWriter();
            var regs = AsmRegs.list(GP);
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

        [CmdOp(".emit-modrm-bits")]
        Outcome EmitModRmFields(CmdArgs args)
        {
            var path = Workspace.Bitfield("modrm");
            var flow = Wf.EmittingFile(path);
            using var writer = path.AsciWriter();
            var dst = span<char>(256*128);
            var count = AsmRender.modRmBits(dst);
            var rendered = slice(dst,0,count);
            writer.Write(rendered);
            Wf.EmittedFile(flow,count);
            return true;
        }

        [CmdOp(".emit-rex-bits")]
        Outcome EmitRexFields(CmdArgs args)
        {
            var path = Workspace.Bitfield("rex");
            var flow = Wf.EmittingFile(path);
            var bits = RexPrefix.Range();
            using var writer = path.AsciWriter();
            var buffer = text.buffer();
            var count = AsmRender.RexTable(buffer);
            writer.Write(buffer.Emit());
            Wf.EmittedFile(flow,count);
            return true;
        }

        [CmdOp(".emit-modrm-tables")]
        Outcome EmitModRmTables(CmdArgs args)
        {
            const string Pattern = "{0,-3} | {1,-3} | {2,-3} | {3,-3} | {4}";
            var header = string.Format(Pattern, "mod", "reg", "r/m", "hex", "bitstring");
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
                        var fCode = code.FormatHex(specifier:false);
                        var fMod = BitRender.format(n2, mod);
                        var fReg = BitRender.format(n3, reg);
                        var fRm = BitRender.format(n3, rm);
                        var bitstring = string.Format("{0} {1} {2}", fMod, fReg, fRm);
                        var row = string.Format(Pattern, fMod, fReg, fRm, fCode, bitstring);
                        writer.WriteLine(row);
                        counter++;
                    }
                }
            }
            Wf.EmittedFile(flow,counter);
            return true;
        }

        [CmdOp(".emit-reg-grids")]
        Outcome EmitRegGrids(CmdArgs args)
        {
            var dst = Workspace.Table("regs",FS.Csv);
            var counter = 0u;
            var flow = Wf.EmittingFile(dst);
            var grids = Wf.AsmRegGrids();
            using var writer = dst.AsciWriter();
            counter += grids.Emit(grids.Grid(GP, w8),writer);
            counter += grids.Emit(grids.Grid(GP, w8,true), writer);
            counter += grids.Emit(grids.Grid(GP, w16),writer);
            counter += grids.Emit(grids.Grid(GP, w32),writer);
            counter += grids.Emit(grids.Grid(GP, w64),writer);
            Wf.EmittedFile(flow,counter);
            return true;
        }

        [CmdOp(".import-cpuid")]
        Outcome ImportCpuid(CmdArgs args)
        {
            return Wf.AsmDataPipes().ImportCpuIdSources();
        }
    }
}