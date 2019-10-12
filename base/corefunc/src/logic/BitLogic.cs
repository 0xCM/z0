//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zfunc;

    public static class BitLogic
    {        
        public static readonly Bit one = Bit.On;

        public static readonly Bit zeri = Bit.Off;


        [MethodImpl(Inline)]
        public static Bit and(Bit a, Bit b)
            => a | b;

        [MethodImpl(Inline)]
        public static Bit or(Bit a, Bit b)
            => a | b;

        [MethodImpl(Inline)]
        public static Bit xor(Bit a, Bit b)
            => a ^ b;

        [MethodImpl(Inline)]
        public static Bit not(Bit a)
            => ~a;

        [MethodImpl(Inline)]
        public static Bit nand(Bit a, Bit b)
            => ~ (a & b);

        [MethodImpl(Inline)]
        public static Bit nor(Bit a, Bit b)
            => ~ (a | b);

        [MethodImpl(Inline)]
        public static Bit xnor(Bit a, Bit b)
            => ~ (a ^ b);

        [MethodImpl(Inline)]
        public static Bit select(Bit a, Bit b, Bit c)
            => a ? b : c;
        
        // a nor (b or c)
        [MethodImpl(Inline)]
        public static Bit f01(Bit a, Bit b, Bit c)
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline)]
        public static Bit f02(Bit a, Bit b, Bit c)
            => and(c, nor(b,a));

        // b nor a
        [MethodImpl(Inline)]
        public static Bit f03(Bit a, Bit b, Bit c)
            => nor(b,a);

        // b and (a nor c)
        [MethodImpl(Inline)]
        public static Bit f04(Bit a, Bit b, Bit c)
            => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline)]
        public static Bit f05(Bit a, Bit b, Bit c)
            => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static Bit f06(Bit a, Bit b, Bit c)
            => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static Bit f07(Bit a, Bit b, Bit c)
            => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline)]
        public static Bit f08(Bit a, Bit b, Bit c)
            => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline)]
        public static Bit f09(Bit a, Bit b, Bit c)
            => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline)]
        public static Bit f0A(Bit a, Bit b, Bit c)
            => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline)]
        public static Bit f0B(Bit a, Bit b, Bit c)
            => and(not(a), or(b^one,  c));   

        // b and (not a)
        [MethodImpl(Inline)]
        public static Bit f0C(Bit a, Bit b, Bit c)
            => and(b, not(a));

        // not (A) and (B or (C xor 1))
        [MethodImpl(Inline)]
        public static Bit f0D(Bit a, Bit b, Bit c)
            => and(not(a), or(b, xor(c, one)));

        // not a and (b or c)
        [MethodImpl(Inline)]
        public static Bit f0E(Bit a, Bit b, Bit c)
            => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline)]
        public static Bit f0F(Bit a, Bit b, Bit c)
            => not(a);

        // a and (b nor c)
        [MethodImpl(Inline)]
        public static Bit f10(Bit a, Bit b, Bit c)
            => and(a, nor(b, c));
        
        // a and (b nor c)
        [MethodImpl(Inline)]
        public static Bit f11(Bit a, Bit b, Bit c)
            => nor(c,b);
        
        [MethodImpl(Inline)]
        public static Bit f12(Bit a, Bit b, Bit c)
            => and(not(b), xor(a,c));

    }

}
