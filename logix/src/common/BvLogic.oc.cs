//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIBitVector64
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    public static partial class loc
    {
        public static BitVector64 and_bv64u(BitVector64 a, BitVector64 b)
            => BvLogic.and(a,b);

        public static BitVector64 or_bv64u(BitVector64 a, BitVector64 b)
            => BvLogic.or(a,b);

        public static BitVector64 xor_bv64u(BitVector64 a, BitVector64 b)
            => BvLogic.xor(a,b);

        public static BitVector64 not_bv64u(BitVector64 a)
            => BvLogic.not(a);

        public static BitVector64 nand_bv64u(BitVector64 a, BitVector64 b)
            => BvLogic.nand(a,b);

        public static BitVector64 nor_bv64u(BitVector64 a, BitVector64 b)
            => BvLogic.nor(a,b);

        public static BitVector64 xnor_bv64u(BitVector64 a, BitVector64 b)
            => BvLogic.xnor(a,b);

        public static BitVector64 xor1_bv64u(BitVector64 a)
            => BvLogic.xor1(a);

        // a ? b : c
        public static BitVector64 select_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.select(a,b,c);
        
        // a nor (b or c)
        public static BitVector64 f01_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f01(a,b,c);

        // c and (b nor a)
        public static BitVector64 f02_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f02(a,b,c);
 
         // b nor a
        public static BitVector64 f03_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f03(a,b,c);

        // b and (a nor c)
        public static BitVector64 f04_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f04(a,b,c);

        // c nor a
        public static BitVector64 f05_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f05(a,b,c);

        // not a and (b xor c)
        public static BitVector64 f06_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f06(a,b,c);

        // not a and (b xor c)
        public static BitVector64 f07_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f07(a,b,c);

        // (not a and b) and c
        public static BitVector64 f08_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f08(a,b,c);

        // a nor (b xor c)
        public static BitVector64 f09_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f09(a,b,c);

        // c and (not a)
        public static BitVector64 f0a_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f0a(a,b,c);

        // not a and ((b xor 1) or c)
        public static BitVector64 f0b_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f0b(a,b,c);

        // b and (not a)
        public static BitVector64 f0c_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f0c(a,b,c);

        // not (A) and (B or (C xor 1))
        public static BitVector64 f0d_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f0d(a,b,c);

        // not a and (b or c)
        public static BitVector64 f0e_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f0e(a,b,c);

        // not a
        public static BitVector64 f0f_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f0f(a,b,c);

        // a and (b nor c)
        public static BitVector64 f10_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f10(a,b,c);
        
        // a and (b nor c)
        public static BitVector64 f11_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f11(a,b,c);
        
        // not b and (a xor c) 
        public static BitVector64 f12_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f12(a,b,c);

        public static BitVector64 f13_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f13(a,b,c);

        public static BitVector64 f14_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f14(a,b,c);

        public static BitVector64 f15_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f15(a,b,c);

        // a ? (b nor c) : (b xor c)
        public static BitVector64 f16_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f16(a,b,c);
 
        public static BitVector64 f17_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f17(a,b,c);

        public static BitVector64 f18_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f18(a,b,c);

        public static BitVector64 f19_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f19(a,b,c);

        public static BitVector64 f1a_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f1a(a,b,c);

        public static BitVector64 f1b_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BvLogic.f1b(a,b,c);


    }
}