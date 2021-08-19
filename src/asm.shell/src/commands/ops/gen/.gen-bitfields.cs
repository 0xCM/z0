//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".gen-bitfields")]
        Outcome GenBitfields(CmdArgs args)
        {
            var result = GenModRmBits();
            if(result.Fail)
                return result;

            result = GenSibBits();
            if(result.Fail)
                return result;

            return result;
        }

        Outcome GenSibBits()
        {
            var result = Outcome.Success;
            var path = Gen().Path("bitfields", "sib", FS.ext("bits"));
            var flow = Wf.EmittingFile(path);
            using var writer = path.AsciWriter();
            var dst = span<char>(256*128);
            var count = AsmBits.bitfield3x3x2(dst);
            var rendered = slice(dst,0,count);
            writer.Write(rendered);
            Wf.EmittedFile(flow,count);
            return result;
        }

        Outcome GenModRmBits()
        {
            var path = Gen().Path("bitfields", "modrm", FS.ext("bits"));
            var flow = Wf.EmittingFile(path);
            using var writer = path.AsciWriter();
            var dst = span<char>(256*128);
            var count = AsmBits.ModRmTable(dst);
            var rendered = slice(dst,0,count);
            writer.Write(rendered);
            Wf.EmittedFile(flow,count);
            return true;
        }
    }
}