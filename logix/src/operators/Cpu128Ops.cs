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
    using System.Runtime.Intrinsics;

    using static zfunc;    
    using static As;

    public static class Cpu128Ops
    {

        [MethodImpl(Inline)]
        public static Vector128<T> identity<T>(Vector128<T> a)
            where T : unmanaged
                => a;

        [MethodImpl(Inline)]
        public static Vector128<T> zero<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vector128<T> one<T>()
            where T : unmanaged
                => Vec128Pattern.ones<T>();

        [MethodImpl(Inline)]
        public static Vector128<T> not<T>(Vector128<T> a)
            where T : unmanaged
                => ginx.vnot(a);

        [MethodImpl(Inline)]
        public static Vector128<T> add<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => ginx.vadd(a,b);

        [MethodImpl(Inline)]
        public static Vector128<T> sub<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => ginx.vsub(a,b);

        [MethodImpl(Inline)]
        public static Vector128<T> and<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => ginx.vand(a,b);

        [MethodImpl(Inline)]
        public static Vector128<T> andnot<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => ginx.vandnot(a,b);

        [MethodImpl(Inline)]
        public static Vector128<T> nand<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => not(and(a,b));

        [MethodImpl(Inline)]
        public static Vector128<T> sll<T>(Vector128<T> a, int offset)
            where T : unmanaged
                => ginx.vsll<T>(a,(byte)offset);

        [MethodImpl(Inline)]
        public static Vector128<T> srl<T>(Vector128<T> a, int offset)
            where T : unmanaged
                => ginx.vsrl<T>(a,(byte)offset);

        [MethodImpl(Inline)]
        public static Vector128<T> rotl<T>(Vector128<T> a, int offset)
            where T : unmanaged
                => ginx.vrotl<T>(a,(byte)offset);

        [MethodImpl(Inline)]
        public static Vector128<T> rotr<T>(Vector128<T> a, int offset)
            where T : unmanaged
                => ginx.vrotr<T>(a,(byte)offset);

        [MethodImpl(Inline)]
        public static Vector128<T> negate<T>(Vector128<T> a)
            where T : unmanaged
                => ginx.vnegate<T>(a);


        [MethodImpl(Inline)]
        public static Vector128<T> or<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => ginx.vor(a,b);

        [MethodImpl(Inline)]
        public static Vector128<T> nor<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => ginx.vnor(a,b);

        [MethodImpl(Inline)]
        public static Vector128<T> xor<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => ginx.vxor(a,b);

        [MethodImpl(Inline)]
        public static Vector128<T> xnor<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => ginx.vxnor(a,b);

        [MethodImpl(Inline)]
        public static Vector128<T> xor1<T>(Vector128<T> a)
            where T : unmanaged
                => ginx.vxor1(a);

        [MethodImpl(Inline)]
        public static Vector128<T> select<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => ginx.vselect(a,b,c);  //or(and(a, b), and(not(a), c));

        // a nor (b or c)
        [MethodImpl(Inline)]
        public static Vector128<T> f01<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline)]
        public static Vector128<T> f02<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(c, nor(b,a));
 
         // b nor a
        [MethodImpl(Inline)]
        public static Vector128<T> f03<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => nor(b,a);

       // b and (a nor c)
        [MethodImpl(Inline)]
        public static Vector128<T> f04<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline)]
        public static Vector128<T> f05<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static Vector128<T> f06<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static Vector128<T> f07<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline)]
        public static Vector128<T> f08<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline)]
        public static Vector128<T> f09<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline)]
        public static Vector128<T> f0a<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline)]
        public static Vector128<T> f0b<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(not(a), or(xor1(b),  c));   

        // b and (not a)
        [MethodImpl(Inline)]
        public static Vector128<T> f0c<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(b, not(a));

        // not a and (b or (c xor 1))
        [MethodImpl(Inline)]
        public static Vector128<T> f0d<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(not(a), or(b, xor1(c)));

        // not a and (b or c)
        [MethodImpl(Inline)]
        public static Vector128<T> f0e<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline)]
        public static Vector128<T> f0f<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => not(a);

        // a and (b nor c)
        [MethodImpl(Inline)]
        public static Vector128<T> f10<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(a, nor(b, c));
        
        // c nor b
        [MethodImpl(Inline)]
        public static Vector128<T> f11<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => nor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline)]
        public static Vector128<T> f12<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline)]
        public static Vector128<T> f13<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline)]
        public static Vector128<T> f14<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline)]
        public static Vector128<T> f15<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => nor(c, and(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline)]
        public static Vector128<T> f16<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => select(a, nor(b,c), xor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline)]
        public static Vector128<T> f17<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => not(select(a, or(b,c), and(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline)]
        public static Vector128<T> f18<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline)]
        public static Vector128<T> f19<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline)]
        public static Vector128<T> f1a<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline)]
        public static Vector128<T> f1b<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => select(c, not(a), not(b));

        // a ? (b xnor c) : (b nand c)
        [MethodImpl(Inline)]
        public static Vector128<T> f97<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => select(c, xnor(b,c), nand(b,c));

        }
}

