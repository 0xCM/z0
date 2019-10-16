//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIBit
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    public static partial class loc
    {
        public static Bit and_bit(Bit a, Bit b)
            => BitLogic.and(a,b);

        public static Bit or_bit(Bit a, Bit b)
            => BitLogic.or(a,b);

        public static Bit xor_bit(Bit a, Bit b)
            => BitLogic.xor(a,b);

        public static Bit not_bit(Bit a)
            => BitLogic.not(a);

        public static Bit nand_bit(Bit a, Bit b)
            => BitLogic.nand(a,b);

        public static Bit nor_bit(Bit a, Bit b)
            => BitLogic.nor(a,b);

        public static Bit xnor_bit(Bit a, Bit b)
            => BitLogic.xnor(a,b);

        public static bool xnor_bool(bool a, bool b)
            => BoolLogic.xnor(a,b);

        public static Bit xor1_bit(Bit a)
            => BitLogic.xor1(a);
        

        // a ? b : c
        public static Bit select_bit(Bit a, Bit b, Bit c)
            => BitLogic.select(a,b,c);
        
        // a nor (b or c)
        public static Bit f01_bit(Bit a, Bit b, Bit c)
            => BitLogic.f01(a,b,c);

        // c and (b nor a)
        public static Bit f02_bit(Bit a, Bit b, Bit c)
            => BitLogic.f02(a,b,c);
 
         // b nor a
        public static Bit f03_bit(Bit a, Bit b, Bit c)
            => BitLogic.f03(a,b,c);

        // b and (a nor c)
        public static Bit f04_bit(Bit a, Bit b, Bit c)
            => BitLogic.f04(a,b,c);

        // c nor a
        public static Bit f05_bit(Bit a, Bit b, Bit c)
            => BitLogic.f05(a,b,c);

        // not a and (b xor c)
        public static Bit f06_bit(Bit a, Bit b, Bit c)
            => BitLogic.f06(a,b,c);

        // not a and (b xor c)
        public static Bit f07_bit(Bit a, Bit b, Bit c)
            => BitLogic.f07(a,b,c);

        // (not a and b) and c
        public static Bit f08_bit(Bit a, Bit b, Bit c)
            => BitLogic.f08(a,b,c);

        // a nor (b xor c)
        public static Bit f09_bit(Bit a, Bit b, Bit c)
            => BitLogic.f09(a,b,c);

        // c and (not a)
        public static Bit f0a_bit(Bit a, Bit b, Bit c)
            => BitLogic.f0a(a,b,c);

        // not a and ((b xor 1) or c)
        public static Bit f0b_bit(Bit a, Bit b, Bit c)
            => BitLogic.f0b(a,b,c);

        // b and (not a)
        public static Bit f0c_bit(Bit a, Bit b, Bit c)
            => BitLogic.f0c(a,b,c);

        // not (A) and (B or (C xor 1))
        public static Bit f0d_bit(Bit a, Bit b, Bit c)
            => BitLogic.f0d(a,b,c);

        // not a and (b or c)
        public static Bit f0e_bit(Bit a, Bit b, Bit c)
            => BitLogic.f0e(a,b,c);

        // not a
        public static Bit f0f_bit(Bit a, Bit b, Bit c)
            => BitLogic.f0f(a,b,c);

        // a and (b nor c)
        public static Bit f10_bit(Bit a, Bit b, Bit c)
            => BitLogic.f10(a,b,c);
        
        // a and (b nor c)
        public static Bit f11_bit(Bit a, Bit b, Bit c)
            => BitLogic.f11(a,b,c);
        
        // not b and (a xor c) 
        public static Bit f12_bit(Bit a, Bit b, Bit c)
            => BitLogic.f12(a,b,c);

        public static Bit f13_bit(Bit a, Bit b, Bit c)
            => BitLogic.f13(a,b,c);

        public static Bit f14_bit(Bit a, Bit b, Bit c)
            => BitLogic.f14(a,b,c);

        public static Bit f15_bit(Bit a, Bit b, Bit c)
            => BitLogic.f15(a,b,c);

        // a ? (b nor c) : (b xor c)
        public static Bit f16_bit(Bit a, Bit b, Bit c)
            => BitLogic.f16(a,b,c);
 
        public static Bit f17_bit(Bit a, Bit b, Bit c)
            => BitLogic.f17(a,b,c);

        public static Bit f18_bit(Bit a, Bit b, Bit c)
            => BitLogic.f18(a,b,c);

        public static Bit f19_bit(Bit a, Bit b, Bit c)
            => BitLogic.f19(a,b,c);

        public static Bit f1a_bit(Bit a, Bit b, Bit c)
            => BitLogic.f1a(a,b,c);

        public static Bit f1b_bit(Bit a, Bit b, Bit c)
            => BitLogic.f1b(a,b,c);


    }
}