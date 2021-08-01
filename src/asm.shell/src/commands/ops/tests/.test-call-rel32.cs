//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmEncodings;

    partial class AsmCmdService
    {
        [CmdOp(".test-call-rel32")]
        Outcome TestCallRel32(CmdArgs args)
        {
            const ulong FunctionBase = 0x7ffc56862280;
            const ushort InstructionOffset = 0x25;
            const uint Displacement = 0xfc632176;

            var result = Outcome.Success;

            MemoryAddress client = FunctionBase + InstructionOffset;
            var call = Calls.rel32(client,Displacement);
            Write(AsmRender.format(call));

            return result;
        }

        [CmdOp(".asm-call-rel32")]
        Outcome AsmCallRel32(CmdArgs args)
        {
            const string input = "e8 d1 d5 b3 59";
            var result = asm.hexbytes(input, out var code);
            if(result.Fail)
                return result;

            result = asm.rel32dx(code, out var disp);
            if(result.Fail)
                return (false, string.Format("The input {0} is not a rel32 call"));

            Write(string.Format("{0} => disp{1:x8}", input, disp));

            return result;
        }
    }
}