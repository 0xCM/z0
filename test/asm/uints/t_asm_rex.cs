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
        void rex_field_reader()
        {
            var rw48 = RexPrefixBits.Define(b:0, x:0, r:0, w:1, RexPrefixCode.Rex43);
            Claim.eq(rw48.B, bit.Off);
            Claim.eq(rw48.X, bit.Off);
            Claim.eq(rw48.R, bit.Off);
            Claim.eq(rw48.W, bit.On);
            Claim.eq(rw48.Code, RexPrefixCode.Rex43);
            Claim.eq((byte)0x48,rw48.Scalar);

            var rw49 = RexPrefixBits.Define(b:1, x:0, r:0, w:1, RexPrefixCode.Rex43);
            Claim.eq(rw49.B, 1);
            Claim.eq(rw49.X, 0);
            Claim.eq(rw49.R, 0);
            Claim.eq(rw49.W, 1);
            Claim.eq(rw49.Code, RexPrefixCode.Rex43);
            Claim.eq((byte)0x49,rw49.Scalar);
        }

        public void rex_field_writer()
        {
            var bf = RexPrefixBits.BitField;
            var src = RexPrefixBits.Define(b:0, x:0, r:0, w:1, RexPrefixCode.Rex43);
            var dst = RexPrefixBits.Empty;
            RexPrefixBits.BitCopy(src,ref dst);

            Claim.ClaimEq(src.Render(), dst.Render());
        }
    }
}