//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_asm_sqrt : AsmOpTest<t_asm_sqrt>
    {        
        protected override string OpName 
            => "sqrt";

        public void Verify()
        {
            var data = "0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x51,0xC0,0xC3";
            var code = AsmCode.Parse(data, moniker<double>(OpName));
            using var buffer = AsmExecBuffer.Create();
            buffer.Load(code);
            CheckMatch(buffer.UnaryOp<double>(),fmath.sqrt);                        
        }

             
    }


}
