//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
 
    public class t_asm_rex : t_asmd<t_asm_rex>
    {
        void rex_field_reader()
        {
            var rw48 = RexPrefix.Define(b:0, x:0, r:0, w:1, RexPrefixCode.Rex43);
            Claim.Eq(rw48.B, 0);
            Claim.Eq(rw48.X, 0);
            Claim.Eq(rw48.R, 0);
            Claim.Eq(rw48.W, 1);
            Claim.Eq(rw48.Code, RexPrefixCode.Rex43);
            Claim.Eq((byte)0x48,rw48.Scalar);
            
            var rw49 = RexPrefix.Define(b:1, x:0, r:0, w:1, RexPrefixCode.Rex43);
            Claim.Eq(rw49.B, 1);
            Claim.Eq(rw49.X, 0);
            Claim.Eq(rw49.R, 0);
            Claim.Eq(rw49.W, 1);
            Claim.Eq(rw49.Code, RexPrefixCode.Rex43);
            Claim.Eq((byte)0x49,rw49.Scalar);
        }


        public void rex_field_writer()
        {
            var bf = RexPrefix.BitField;
            var src = RexPrefix.Define(b:0, x:0, r:0, w:1, RexPrefixCode.Rex43);
            var dst = RexPrefix.Empty;            
            RexPrefix.BitCopy(src,ref dst);
            
            Claim.eq(src.Render(), dst.Render());
        }
    }
}