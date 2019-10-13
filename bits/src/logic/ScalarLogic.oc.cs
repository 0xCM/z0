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
        public static ulong and_64u(ulong a, ulong b)
            => ScalarLogic.and(a,b);

        public static ulong or_64u(ulong a, ulong b)
            => ScalarLogic.or(a,b);

        public static ulong xor_64u(ulong a, ulong b)
            => ScalarLogic.xor(a,b);

        public static ulong not_64u(ulong a)
            => ScalarLogic.not(a);

        public static ulong nand_64u(ulong a, ulong b)
            => ScalarLogic.nand(a,b);

        public static ulong nor_64u(ulong a, ulong b)
            => ScalarLogic.nor(a,b);

        public static ulong xnor_64u(ulong a, ulong b)
            => ScalarLogic.xnor(a,b);

        public static ulong xor1_64u(ulong a)
            => ScalarLogic.xor1(a);

        // a ? b : c
        public static ulong select_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.select(a,b,c);
        
        // a nor (b or c)
        public static ulong f01_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f01(a,b,c);

        // c and (b nor a)
        public static ulong f02_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f02(a,b,c);
 
         // b nor a
        public static ulong f03_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f03(a,b,c);

        // b and (a nor c)
        public static ulong f04_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f04(a,b,c);

        // c nor a
        public static ulong f05_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f05(a,b,c);

        // not a and (b xor c)
        public static ulong f06_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f06(a,b,c);

        // not a and (b xor c)
        public static ulong f07_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f07(a,b,c);

        // (not a and b) and c
        public static ulong f08_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f08(a,b,c);

        // a nor (b xor c)
        public static ulong f09_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f09(a,b,c);

        // c and (not a)
        public static ulong f0a_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0a(a,b,c);

        // not a and ((b xor 1) or c)
        public static ulong f0b_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0b(a,b,c);

        // b and (not a)
        public static ulong f0c_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0c(a,b,c);

        // not (A) and (B or (C xor 1))
        public static ulong f0d_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0d(a,b,c);

        // not a and (b or c)
        public static ulong f0e_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0e(a,b,c);

        // not a
        public static ulong f0f_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0f(a,b,c);

        // a and (b nor c)
        public static ulong f10_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f10(a,b,c);
        
        // a and (b nor c)
        public static ulong f11_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f11(a,b,c);
        
        // not b and (a xor c) 
        public static ulong f12_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f12(a,b,c);

        public static ulong f13_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f13(a,b,c);

        public static ulong f14_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f14(a,b,c);

        public static ulong f15_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f15(a,b,c);

        // a ? (b nor c) : (b xor c)
        public static ulong f16_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f16(a,b,c);
 
        public static ulong f17_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f17(a,b,c);

        public static ulong f18_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f18(a,b,c);

        public static ulong f19_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f19(a,b,c);

        public static ulong f1a_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f1a(a,b,c);

        public static ulong f1b_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f1b(a,b,c);

        public static ulong f97_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f97(a,b,c);

    }
}