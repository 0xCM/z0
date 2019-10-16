//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIulong
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    public static partial class loc
    {
 

        //b ? (not a) : (not c)
        public static ulong f1d(ulong a, ulong b, ulong c)
            => ScalarLogic.f1d(a,b,c);

        //a xor (b or c)
        public static ulong f1e(ulong a, ulong b, ulong c)
            => ScalarLogic.f1e(a,b,c);

        //a nand (b or c)
        public static ulong f1f(ulong a, ulong b, ulong c)
            => ScalarLogic.f1f(a,b,c);

        //(not (B) and A) and C
        public static ulong f20(ulong a, ulong b, ulong c)
            => ScalarLogic.f20(a,b,c);

        public static ulong f21(ulong a, ulong b, ulong c)
            => ScalarLogic.f21(a,b,c);

        public static ulong f22(ulong a, ulong b, ulong c)
            => ScalarLogic.f22(a,b,c);

        public static ulong f23(ulong a, ulong b, ulong c)
            => ScalarLogic.f23(a,b,c);

        public static ulong f24(ulong a, ulong b, ulong c)
            => ScalarLogic.f24(a,b,c);

        public static ulong f25(ulong a, ulong b, ulong c)
            => ScalarLogic.f25(a,b,c);

        public static ulong f97_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f97(a,b,c);





        // a ? (b nor c) : (b xor c)
        public static BitVector64 f16_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => VectorLogic.f16(a,b,c);
 
        public static BitVector64 f17_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => VectorLogic.f17(a,b,c);

        public static BitVector64 f18_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => VectorLogic.f18(a,b,c);

        public static BitVector64 f19_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => VectorLogic.f19(a,b,c);

        public static BitVector64 f1a_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => VectorLogic.f1a(a,b,c);

        public static BitVector64 f1b_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => VectorLogic.f1b(a,b,c);


    }
}