//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static As;

    public readonly struct BitLogic<T>
        where T : unmanaged
    {
        public static readonly T one = gmath.negate(gmath.one<T>());

        public static readonly T zero = default;
        
        [MethodImpl(Inline)]
        public static T and(T a, T b)
            => gmath.and(a,b);

        [MethodImpl(Inline)]
        public static T or(T a, T b)
            => gmath.or(a,b);

        [MethodImpl(Inline)]
        public static T xor(T a, T b)
            => gmath.xor(a,b);

        [MethodImpl(Inline)]
        public static T not(T a)
            => gmath.flip(a);

        [MethodImpl(Inline)]
        public static T xor1(T a)
            => gmath.xor1(a); 

        [MethodImpl(Inline)]
        public static T nand(T a, T b)
            => not(and(a,b));

        [MethodImpl(Inline)]
        public static T nor(T a, T b)
            => not(or(a,b));

        [MethodImpl(Inline)]
        public static T xnor(T a, T b)
            => not(xor(a,b));

        // a ? b : c
        [MethodImpl(Inline)]
        public static T select(T a, T b, T c)
            => or(and(a, b), and(not(a), c));
        
        // a nor (b or c)
        [MethodImpl(Inline)]
        public static T f01(T a, T b, T c)
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline)]
        public static T f02(T a, T b, T c)
            => and(c, nor(b,a));
 
         // b nor a
        [MethodImpl(Inline)]
        public static T f03(T a, T b, T c)
            => nor(b,a);

        // b and (a nor c)
        [MethodImpl(Inline)]
        public static T f04(T a, T b, T c)
            => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline)]
        public static T f05(T a, T b, T c)
            => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static T f06(T a, T b, T c)
            => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static T f07(T a, T b, T c)
            => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline)]
        public static T f08(T a, T b, T c)
            => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline)]
        public static T f09(T a, T b, T c)
            => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline)]
        public static T f0A(T a, T b, T c)
            => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline)]
        public static T f0B(T a, T b, T c)
            => and(not(a), or(xor1(b),  c));   

        // b and (not a)
        [MethodImpl(Inline)]
        public static T f0C(T a, T b, T c)
            => and(b, not(a));

        // not a and (b or (c xor 1))
        [MethodImpl(Inline)]
        public static T f0D(T a, T b, T c)
        {
            var y = or(b, xor1(c));
            var z = not(a);
            return and(z, y);
        }

        // not a and (b or c)
        [MethodImpl(Inline)]
        public static T f0E(T a, T b, T c)
            => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline)]
        public static T f0F(T a, T b, T c)
            => not(a);

        // a and (b nor c)
        [MethodImpl(Inline)]
        public static T f10(T a, T b, T c)
            => and(a, nor(b, c));
        
        // a and (b nor c)
        [MethodImpl(Inline)]
        public static T f11(T a, T b, T c)
            => nor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline)]
        public static T f12(T a, T b, T c)
            => and(not(b), xor(a,c));
    }    

}