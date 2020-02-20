//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using Z0.Asm.Encoding;

    using static zfunc;

    public class t_asm_rex : t_asm<t_asm_rex>
    {
        public void rex_encode()
        {
            var rw48 = RexPrefix.Define(b:0, x:0, r:0, w:1, RexCode.REX43h);
            Claim.eq(rw48.B, 0);
            Claim.eq(rw48.X, 0);
            Claim.eq(rw48.R, 0);
            Claim.eq(rw48.W, 1);
            Claim.eq(rw48.Code, RexCode.REX43h);
            Claim.eq((byte)0x48,rw48.Data);
            
            Trace(rw48.Format());
            Trace(rw48.Format(NumericBase.Hex));

            var rw49 = RexPrefix.Define(b:1, x:0, r:0, w:1, RexCode.REX43h);
            Claim.eq(rw49.B, 1);
            Claim.eq(rw49.X, 0);
            Claim.eq(rw49.R, 0);
            Claim.eq(rw49.W, 1);
            Claim.eq(rw49.Code, RexCode.REX43h);
            Claim.eq((byte)0x49,rw49.Data);
            
            Trace(rw49.Format());
            Trace(rw49.Format(NumericBase.Hex));

        }
    }

}