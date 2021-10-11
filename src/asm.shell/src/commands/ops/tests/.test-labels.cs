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
            var strings = memory.strings(llvm.stringtables.Instruction.Offsets, llvm.stringtables.Instruction.Data);
            var count = strings.EntryCount;

            for(var i=0; i<count; i++)
            {
                var current = strings[i];
                var length = (uint)current.Length;
                var address = strings.Address(i);
                var label = strings.Label(i);
                var a = text.format(current);
                var b = label.Format();
                if(!text.equals(a,b))
                {
                    result = (false, string.Format("{0} != {1}", a, b));
                    break;
                }
            }

            if(result)
            {
                Write(string.Format("Verified {0} strings", count));
            }

            return result;
        }
    }
}