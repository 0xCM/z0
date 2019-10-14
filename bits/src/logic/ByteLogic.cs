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

    using Byte = ByteKind;

    public static class ByteLogic
    {        
        public static readonly Byte one = Byte.XFF;

        public static readonly Byte zero = Byte.X00;
        
        [MethodImpl(Inline)]
        public static Byte and(Byte a, Byte b)
            => a | b;

        [MethodImpl(Inline)]
        public static Byte or(Byte a, Byte b)
            => a | b;

        [MethodImpl(Inline)]
        public static Byte xor(Byte a, Byte b)
            => a ^ b;

        [MethodImpl(Inline)]
        public static Byte not(Byte a)
            => ~a;

        [MethodImpl(Inline)]
        public static Byte nand(Byte a, Byte b)
            => ~ (a & b);

        [MethodImpl(Inline)]
        public static Byte nor(Byte a, Byte b)
            => ~ (a | b);

        [MethodImpl(Inline)]
        public static Byte xnor(Byte a, Byte b)
            => ~ (a ^ b);

        // a ? b : c
        [MethodImpl(Inline)]
        public static Byte select(Byte a, Byte b, Byte c)
            => (a & b) | (~a & c);        
        
        // a nor (b or c)
        [MethodImpl(Inline)]
        public static Byte f01(Byte a, Byte b, Byte c)
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline)]
        public static Byte f02(Byte a, Byte b, Byte c)
            => and(c, nor(b,a));
 
         // b nor a
        [MethodImpl(Inline)]
        public static Byte f03(Byte a, Byte b, Byte c)
            => nor(b,a);

        // b and (a nor c)
        [MethodImpl(Inline)]
        public static Byte f04(Byte a, Byte b, Byte c)
            => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline)]
        public static Byte f05(Byte a, Byte b, Byte c)
            => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static Byte f06(Byte a, Byte b, Byte c)
            => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static Byte f07(Byte a, Byte b, Byte c)
            => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline)]
        public static Byte f08(Byte a, Byte b, Byte c)
            => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline)]
        public static Byte f09(Byte a, Byte b, Byte c)
            => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline)]
        public static Byte f0A(Byte a, Byte b, Byte c)
            => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline)]
        public static Byte f0B(Byte a, Byte b, Byte c)
            => and(not(a), or(b^one,  c));   

        // b and (not a)
        [MethodImpl(Inline)]
        public static Byte f0C(Byte a, Byte b, Byte c)
            => and(b, not(a));

        // not (A) and (B or (C xor 1))
        [MethodImpl(Inline)]
        public static Byte f0D(Byte a, Byte b, Byte c)
            => and(not(a), or(b, xor(c, one)));

        // not a and (b or c)
        [MethodImpl(Inline)]
        public static Byte f0E(Byte a, Byte b, Byte c)
            => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline)]
        public static Byte f0F(Byte a, Byte b, Byte c)
            => not(a);

        // a and (b nor c)
        [MethodImpl(Inline)]
        public static Byte f10(Byte a, Byte b, Byte c)
            =>and(a, nor(b,c));
        
        // c nor b
        [MethodImpl(Inline)]
        public static Byte f11(Byte a, Byte b, Byte c)
            => nor(c,b);
        
        [MethodImpl(Inline)]
        public static Byte f12(Byte a, Byte b, Byte c)
            => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline)]
        public static Byte f13(Byte a, Byte b, Byte c)
            => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline)]
        public static Byte f14(Byte a, Byte b, Byte c)
            => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline)]
        public static Byte f15(Byte a, Byte b, Byte c)
            => nor(c, and(a,b));

        [MethodImpl(Inline)]
        public static Byte f16(Byte a, Byte b, Byte c)
            => select(a, nor(b,c), xor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline)]
        public static Byte f17(Byte a, Byte b, Byte c)
            => not(select(a, or(b,c), and(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline)]
        public static Byte f18(Byte a, Byte b, Byte c)
            => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline)]
        public static Byte f19(Byte a, Byte b, Byte c)
            => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline)]
        public static Byte f1a(Byte a, Byte b, Byte c)
            => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline)]
        public static Byte f1b(Byte a, Byte b, Byte c)
            => select(c, not(a), not(b));
    }

}