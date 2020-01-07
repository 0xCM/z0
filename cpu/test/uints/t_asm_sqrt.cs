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

        AsmCode<double> Sqrt64f
            => AsmCode.Parse("0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x51,0xC0,0xC3", moniker(OpName, z64f), z64f);

        public void Verify()
        {
            CheckAsmMatch(fmath.sqrt, Sqrt64f);
        }
             
    }


}
