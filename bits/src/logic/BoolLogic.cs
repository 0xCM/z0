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

    public static class BoolLogic
    {        
        public const bool one = true;

        public const bool zeri = false;


        [MethodImpl(Inline)]
        public static bool and(bool a, bool b)
            => a & b;

        [MethodImpl(Inline)]
        public static bool or(bool a, bool b)
            => a | b;

        [MethodImpl(Inline)]
        public static bool xor(bool a, bool b)
            => a ^ b;

        [MethodImpl(Inline)]
        public static bool not(bool a)
            => !a;

        [MethodImpl(Inline)]
        public static bool nand(bool a, bool b)
            => ! (a & b);

        [MethodImpl(Inline)]
        public static bool nor(bool a, bool b)
            => ! (a | b);

        [MethodImpl(Inline)]
        public static bool xnor(bool a, bool b)
            => ! (a ^ b);

        [MethodImpl(Inline)]
        public static bool select(bool a, bool b, bool c)
            => a ? b : c;
        
        // a nor (b or c)
        [MethodImpl(Inline)]
        public static bool f01(bool a, bool b, bool c)
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline)]
        public static bool f02(bool a, bool b, bool c)
            => and(c, nor(b,a));

        // b nor a
        [MethodImpl(Inline)]
        public static bool f03(bool a, bool b, bool c)
            => nor(b,a);

        // b and (a nor c)
        [MethodImpl(Inline)]
        public static bool f04(bool a, bool b, bool c)
            => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline)]
        public static bool f05(bool a, bool b, bool c)
            => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static bool f06(bool a, bool b, bool c)
            => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static bool f07(bool a, bool b, bool c)
            => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline)]
        public static bool f08(bool a, bool b, bool c)
            => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline)]
        public static bool f09(bool a, bool b, bool c)
            => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline)]
        public static bool f0A(bool a, bool b, bool c)
            => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline)]
        public static bool f0B(bool a, bool b, bool c)
            => and(not(a), or(b^one,  c));   

        // b and (not a)
        [MethodImpl(Inline)]
        public static bool f0C(bool a, bool b, bool c)
            => and(b, not(a));

        // not (A) and (B or (C xor 1))
        [MethodImpl(Inline)]
        public static bool f0D(bool a, bool b, bool c)
            => and(not(a), or(b, xor(c, one)));

        // not a and (b or c)
        [MethodImpl(Inline)]
        public static bool f0E(bool a, bool b, bool c)
            => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline)]
        public static bool f0F(bool a, bool b, bool c)
            => not(a);

        // a and (b nor c)
        [MethodImpl(Inline)]
        public static bool f10(bool a, bool b, bool c)
            => and(a, nor(b, c));
        
        // a and (b nor c)
        [MethodImpl(Inline)]
        public static bool f11(bool a, bool b, bool c)
            => nor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline)]
        public static bool f12(bool a, bool b, bool c)
            => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline)]
        public static bool f13(bool a, bool b, bool c)
            => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline)]
        public static bool f14(bool a, bool b, bool c)
            => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline)]
        public static bool f15(bool a, bool b, bool c)
            => nor(c, and(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline)]
        public static bool f16(bool a, bool b, bool c)
            => select(a, nor(b,c), xor(b,c));

        // a ? (b or c) : (b and c)
        [MethodImpl(Inline)]
        public static bool f17(bool a, bool b, bool c)
            => select(a, or(b,c), and(b,c));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline)]
        public static bool f18(bool a, bool b, bool c)
            => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline)]
        public static bool f19(bool a, bool b, bool c)
            => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline)]
        public static bool f1a(bool a, bool b, bool c)
            => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline)]
        public static bool f1b(bool a, bool b, bool c)
            => select(c, not(a), not(b));
    }

}
