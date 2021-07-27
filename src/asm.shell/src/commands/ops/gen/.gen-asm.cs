//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".gen-asm")]
        Outcome GenAsm(CmdArgs args)
        {
            const string mnemonic = "kandb";
            const string RenderPattern = mnemonic + " {0}";

            var dst = AsmWs.AsmPath(string.Format("{0}.g",mnemonic));
            using var writer = dst.AsciWriter();
            writer.WriteLine("bits 64");

            // a in RCX, b in RDX, c in R8, d in R9
            var counter = 0u;
            var r0 = RegSets.MaskSet();
            var r1 = r0.Replicate();
            var r2 = r0.Replicate();
            for(var i=0u; i<r0.Count; i++)
            for(var j=0u; j<r1.Count; j++)
            for(var k=0u; k<r2.Count; k++)
            {
                if(i==0)
                    continue;

                if(i == j && j == k)
                    continue;

                var asm = string.Format(RenderPattern, format(r0[i], r1[j], r2[k]));
                writer.WriteLine(asm);
                counter++;
            }
            Write(EmittedInstructions.Format(counter,dst));
            return true;
        }

        static string format(RegOp op0, RegOp op1, RegOp op2)
            => string.Format("{0},{1},{2}", op0, op1, op2);

        MsgPattern<Count,FS.FileUri> EmittedInstructions => "Emitted {0} instructions to {1}";
    }
}