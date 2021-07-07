//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    partial class AsmCmdService
    {
        static ReadOnlySpan<byte> min64u_64u_64u
            => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x72,0x04,0x48,0x8b,0xc2,0xc3,0x48,0x8b,0xc1,0xc3};

        Outcome Handle(Outcome result, Action success)
        {
            if(result.Fail)
                Wf.Error(result.Message);
            else
                success();
            return result;
        }

        [CmdOp(".exec")]
        unsafe Outcome Exec(CmdArgs args)
        {
            var name = "min64u";
            var a = 4ul;
            var b = 12ul;
            var block = DynamicOperations.load(min64u_64u_64u, 0, CodeBuffer);
            var f = DynamicOperations.binop<ulong>(name, block);
            DynamicOperations.specify(a, b, ref f);
            DynamicOperations.run(ref f);
            DynamicOperations.format(f, r => Write(r));
            return f.Result;
        }
    }
}