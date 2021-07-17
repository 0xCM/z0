//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm-exec")]
        Outcome AsmExec(CmdArgs args)
        {
            CodeBuffer.Clear();
            var block = DynamicOperations.load(_Assembled, 0, CodeBuffer);
            var f = DynamicOperations.binop<ulong>(RoutineName, block);
            var output = f.Operation.Invoke(3,4);
            Write(string.Format("{0}({1},{2})={3}", f.Name, 3, 4, output));
            return true;
        }
    }
}