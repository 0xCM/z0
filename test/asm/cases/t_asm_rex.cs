//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
 
    using static Seed;
    using static Memories;

    using RFI = Z0.Asm.RexFieldIndex;

    public class t_asm_rex : UnitTest<t_asm_rex>
    {
        public void rex_field_reader()
        {
            var rw48 = RexPrefix.Define(b:0, x:0, r:0, w:1, RexCode.REX43h);
            Claim.eq(rw48.B, 0);
            Claim.eq(rw48.X, 0);
            Claim.eq(rw48.R, 0);
            Claim.eq(rw48.W, 1);
            Claim.eq(rw48.Code, RexCode.REX43h);
            Claim.eq((byte)0x48,rw48.Scalar);
            
            var rw49 = RexPrefix.Define(b:1, x:0, r:0, w:1, RexCode.REX43h);
            Claim.eq(rw49.B, 1);
            Claim.eq(rw49.X, 0);
            Claim.eq(rw49.R, 0);
            Claim.eq(rw49.W, 1);
            Claim.eq(rw49.Code, RexCode.REX43h);
            Claim.eq((byte)0x49,rw49.Scalar);
        }

        public void rex_field_writer_1()
        {
            var bf = AsmBitfields.Rex();
            var src = RexPrefix.Define(b:0, x:0, r:0, w:1, RexCode.REX43h);
            var dst = RexPrefix.Empty;

            bf.Write(RFI.B, src, ref dst.Content);
            bf.Write(RFI.X, src, ref dst.Content);
            bf.Write(RFI.R, src, ref dst.Content);
            bf.Write(RFI.W, src, ref dst.Content);
            bf.Write(RFI.Code, src, ref dst.Content);
            
            Claim.eq(src.Format(), dst.Format());
        }

        public void rex_field_writer_2()
        {
            var bf = AsmBitfields.Rex();
            var src = RexPrefix.Define(b:0, x:0, r:0, w:1, RexCode.REX43h);
            var dst = RexPrefix.Empty;            
            
            bf.Write(RFI.B, src, ref dst);
            bf.Write(RFI.X, src, ref dst);
            bf.Write(RFI.R, src, ref dst);
            bf.Write(RFI.W, src, ref dst);
            bf.Write(RFI.Code, src, ref dst);
                        
            Claim.eq(src.Format(), dst.Format());
        }
    }
}