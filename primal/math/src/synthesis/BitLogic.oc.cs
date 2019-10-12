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

    partial class sloc
    {
        public static ulong and_64u(ulong a, ulong b)
            => BitLogic<ulong>.and(a,b);

        public static ulong or_64u(ulong a, ulong b)
            => BitLogic<ulong>.or(a,b);

        public static ulong xor_64u(ulong a, ulong b)
            => BitLogic<ulong>.xor(a,b);

        public static ulong not_64u(ulong a)
            => BitLogic<ulong>.not(a);

        public static ulong nand_64u(ulong a, ulong b)
            => BitLogic<ulong>.nand(a,b);

        public static ulong nor_64u(ulong a, ulong b)
            => BitLogic<ulong>.nor(a,b);

        public static ulong xnor_64u(ulong a, ulong b)
            => BitLogic<ulong>.xnor(a,b);

        public static ulong xor1_64u(ulong a)
            => BitLogic<ulong>.xor1(a);

        // a ? b : c
        public static ulong select_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.select(a,b,c);
        
        // a nor (b or c)
        public static ulong f01_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f01(a,b,c);

        // c and (b nor a)
        public static ulong f02_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f02(a,b,c);
 
         // b nor a
        public static ulong f03_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f03(a,b,c);

        // b and (a nor c)
        public static ulong f04_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f04(a,b,c);

        // c nor a
        public static ulong f05_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f05(a,b,c);

        // not a and (b xor c)
        public static ulong f06_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f06(a,b,c);

        // not a and (b xor c)
        public static ulong f07_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f07(a,b,c);

        // (not a and b) and c
        public static ulong f08_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f08(a,b,c);

        // a nor (b xor c)
        public static ulong f09_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f09(a,b,c);

        // c and (not a)
        public static ulong f0A_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f0A(a,b,c);

        // not a and ((b xor 1) or c)
        public static ulong f0B_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f0B(a,b,c);

        // b and (not a)
        public static ulong f0C_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f0C(a,b,c);


        // not (A) and (B or (C xor 1))
        public static ulong f0D_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f0D(a,b,c);

        // not a and (b or c)
        public static ulong f0E_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f0E(a,b,c);

        // not a
        public static ulong f0F_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f0F(a,b,c);

        // a and (b nor c)
        public static ulong f10_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f10(a,b,c);
        
        // a and (b nor c)
        public static ulong f11_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f11(a,b,c);
        
        // not b and (a xor c) 
        public static ulong f12_64u(ulong a, ulong b, ulong c)
            => BitLogic<ulong>.f12(a,b,c);
 
    }
}