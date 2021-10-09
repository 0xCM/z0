//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".test-labels")]
        Outcome TestLabels(CmdArgs args)
        {
            var result = Outcome.Success;
            // var services = Wf.Models();
            // var labels = services.Labels(Pow2.T12);
            // var address = labels.BaseAddress;
            // var mask1 = 0x00FFFFFF_FFFFFFFFul;
            // var mask2 = 0x0000FFFF_FFFFFFFFul;

            // var scalar = (ulong)address;
            // MemoryAddress a1 = mask1 & scalar;
            // MemoryAddress a2 = mask2 & scalar;

            // Write(string.Format("a0={0}", address));
            // Write(string.Format("a1={0}", a1));
            // Write(string.Format("a2={0}", a2));

            return result;
        }

    }
}