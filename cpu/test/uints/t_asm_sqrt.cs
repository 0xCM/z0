//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static zfunc;

    public class t_asm_sqrt : AsmOpTest<t_asm_sqrt>
    {        
        public void Verify()
        {
            VerifyOp(AsmOps.Sqrt<float>(), fmath.sqrt, RepCount);
            VerifyOp(AsmOps.Add<double>(), fmath.add, RepCount);
        }

         
    }


}
