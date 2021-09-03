//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using llvm;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-opcodes")]
        Outcome LlvmOpCodes(CmdArgs args)
        {
            var result = Outcome.Success;

            var src = llvm.MC.opcodes().View;
            var formatter = Tables.formatter<OpCodeSpec>();
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(src,i);
                Write(formatter.Format(code));
            }

            return result;
        }
    }
}