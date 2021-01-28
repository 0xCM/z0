//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    public class t_asm_rex : t_asmd<t_asm_rex>
    {
        public void rex_field_encode()
        {
            var encoder = RexPrefixEncoder.create(Wf);
            var rw48 = encoder.Encode(b:0, x:0, r:0, w:1, RexPrefixCode.Rex43);
            Claim.eq(rw48.B, bit.Off);
            Claim.eq(rw48.X, bit.Off);
            Claim.eq(rw48.R, bit.Off);
            Claim.eq(rw48.W, bit.On);
            Claim.eq(rw48.Code, RexPrefixCode.Rex43);
            Claim.eq((byte)0x48, rw48.Scalar);

            var rw49 = encoder.Encode(b:1, x:0, r:0, w:1, RexPrefixCode.Rex43);
            Claim.eq(rw49.B, 1);
            Claim.eq(rw49.X, 0);
            Claim.eq(rw49.R, 0);
            Claim.eq(rw49.W, 1);
            Claim.eq(rw49.Code, RexPrefixCode.Rex43);
            Claim.eq((byte)0x49,rw49.Scalar);
        }
    }
}