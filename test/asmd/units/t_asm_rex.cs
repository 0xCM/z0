//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;

    public class t_asm_rex : t_asmd<t_asm_rex>
    {
        void rex_field_reader()
        {
            var rw48 = RexPrefix.Define(b:0, x:0, r:0, w:1, RexCode.Rex43);
            Claim.eq(rw48.B, 0);
            Claim.eq(rw48.X, 0);
            Claim.eq(rw48.R, 0);
            Claim.eq(rw48.W, 1);
            Claim.eq(rw48.Code, RexCode.Rex43);
            Claim.eq((byte)0x48,rw48.Scalar);
            
            var rw49 = RexPrefix.Define(b:1, x:0, r:0, w:1, RexCode.Rex43);
            Claim.eq(rw49.B, 1);
            Claim.eq(rw49.X, 0);
            Claim.eq(rw49.R, 0);
            Claim.eq(rw49.W, 1);
            Claim.eq(rw49.Code, RexCode.Rex43);
            Claim.eq((byte)0x49,rw49.Scalar);
        }


        public void rex_field_writer()
        {
            var bf = RexPrefix.BitField;
            var src = RexPrefix.Define(b:0, x:0, r:0, w:1, RexCode.Rex43);
            var dst = RexPrefix.Empty;            
            RexPrefix.BitCopy(src,ref dst);
            
            Claim.eq(src.Render(), dst.Render());
        }
    }
}