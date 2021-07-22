//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;

    partial class AsmCmdService
    {
        [CmdOp(".emit-modrm-tables")]
        Outcome EmitModRmTables(CmdArgs args)
        {
            const string Pattern = "{0,-3} | {1,-3} | {2,-3} | {3,-3} | {4}";
            var header = string.Format(Pattern, "mod", "reg", "r/m", "hex", "bitstring");
            var dst = Workspace.Table("modrm", FS.Csv);
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
    }
}