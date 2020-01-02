//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    using static TernaryOpKind;

    public static partial class CpuOps
    {
        [MethodImpl(Inline)]
        public static Vector256<T> @false<T>(N256 n)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vector256<T> @true<T>(N256 n)
            where T:unmanaged
                => VPattern.vones<T>(n256);

        [MethodImpl(Inline)]
        public static Vector256<T> @false<T>(Vector256<T> x)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vector256<T> @true<T>(Vector256<T> x)
            where T:unmanaged
                => VPattern.vones<T>(n256);

        [MethodImpl(Inline)]
        public static Vector256<T> @false<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vector256<T> @true<T>(Vector256<T> x, Vector256<T> y)
            where T:unmanaged
                => VPattern.vones<T>(n256);

        [MethodImpl(Inline)]
        public static Vector256<T> @false<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vector256<T> @true<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T:unmanaged
                => VPattern.vones<T>(n256);

        [MethodImpl(Inline)]
        public static Vector256<T> identity<T>(Vector256<T> a)
            where T : unmanaged
                => a;

        [MethodImpl(Inline)]
        public static Vector256<T> not<T>(Vector256<T> a)
            where T : unmanaged
                => ginx.vnot(a);

        [MethodImpl(Inline)]
        public static Vector256<T> and<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vand(a,b);


        [MethodImpl(Inline)]
        public static Vector256<T> nand<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vnand(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> or<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vor(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> nor<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vnor(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> xor<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vxor(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> xnor<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vxnor(a,b);


        [MethodImpl(Inline)]
        public static Vector256<T> left<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => a;

        [MethodImpl(Inline)]
        public static Vector256<T> lnot<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => not(a);

        [MethodImpl(Inline)]
        public static Vector256<T> right<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => b;

        [MethodImpl(Inline)]
        public static Vector256<T> rnot<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => not(b);

        [MethodImpl(Inline)]
        public static Vector256<T> imply<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vimpl(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> notimply<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vnonimpl(a,b); 

        [MethodImpl(Inline)]
        public static Vector256<T> cimply<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vcimpl(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> cnotimply<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vcnonimpl(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> xornot<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vxornot(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> sll<T>(Vector256<T> a, int offset)
            where T : unmanaged
                => ginx.vsll<T>(a,(byte)offset);

        [MethodImpl(Inline)]
        public static Vector256<T> srl<T>(Vector256<T> a, int offset)
            where T : unmanaged
                => ginx.vsrl<T>(a,(byte)offset);

        [MethodImpl(Inline)]
        public static Vector256<T> rotl<T>(Vector256<T> a, int offset)
            where T : unmanaged
                => ginx.vrotl<T>(a,(byte)offset);

        [MethodImpl(Inline)]
        public static Vector256<T> rotr<T>(Vector256<T> a, int offset)
            where T : unmanaged
                => ginx.vrotr<T>(a,(byte)offset);

        [MethodImpl(Inline)]
        public static Vector256<T> inc<T>(Vector256<T> a)
            where T : unmanaged
                => ginx.vinc(a);

        [MethodImpl(Inline)]
        public static Vector256<T> dec<T>(Vector256<T> a)
            where T : unmanaged
                => ginx.vdec(a);

        [MethodImpl(Inline)]
        public static Vector256<T> negate<T>(Vector256<T> a)
            where T : unmanaged
                => ginx.vnegate<T>(a);

        [MethodImpl(Inline)]
        public static Vector256<T> add<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vadd(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> sub<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vsub(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> equals<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.veq(a,b);

        [MethodImpl(Inline)]
        public static bit same<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vtestc(ginx.veq(a,b));

        [MethodImpl(Inline)]
        public static Vector256<T> lt<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vlt(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> gt<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vgt(a,b);


        [MethodImpl(Inline)]
        public static Vector256<T> max<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => ginx.vmax(a,b);

        [MethodImpl(Inline)]
        public static Vector256<T> select<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => ginx.vselect(a,b,c);

        [MethodImpl(Inline),TernaryOp(X00)]
        public static Vector256<T> f00<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
            => default;


        [MethodImpl(Inline),TernaryOp(X01)]
        public static Vector256<T> f01<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
            => nor(a, or(b,c));

        [MethodImpl(Inline),TernaryOp(X02)]
        public static Vector256<T> f02<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(c, nor(b,a));
 
         // b nor a
        [MethodImpl(Inline),TernaryOp(X03)]
        public static Vector256<T> f03<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(b,a);

       // b and (a nor c)
        [MethodImpl(Inline),TernaryOp(X04)]
        public static Vector256<T> f04<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline),TernaryOp(X05)]
        public static Vector256<T> f05<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(c,a);

        [MethodImpl(Inline),TernaryOp(X06)]
        public static Vector256<T> f06<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(a), xor(b,c));

        [MethodImpl(Inline),TernaryOp(X07)]
        public static Vector256<T> f07<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(a, and(b,c));
        
        [MethodImpl(Inline),TernaryOp(X08)]
        public static Vector256<T> f08<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(and(not(a),b), c);

        [MethodImpl(Inline),TernaryOp(X09)]
        public static Vector256<T> f09<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(a, xor(b,c));

        [MethodImpl(Inline),TernaryOp(X0A)]
        public static Vector256<T> f0a<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline)]
        public static Vector256<T> f0b<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(a), or(not(b),  c));   

        // b and (not a)
        [MethodImpl(Inline)]
        public static Vector256<T> f0c<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(b, not(a));

        // not a and (b or (c xor 1))
        [MethodImpl(Inline)]
        public static Vector256<T> f0d<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(a), or(b, not(c)));


        // not a and (b or c)
        [MethodImpl(Inline)]
        public static Vector256<T> f0e<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(a),or(b,c));


        // not a
        [MethodImpl(Inline)]
        public static Vector256<T> f0f<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => not(a);

        // a and (b nor c)
        [MethodImpl(Inline)]
        public static Vector256<T> f10<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(a, nor(b, c));
        
        // c nor b
        [MethodImpl(Inline)]
        public static Vector256<T> f11<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline)]
        public static Vector256<T> f12<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline)]
        public static Vector256<T> f13<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline)]
        public static Vector256<T> f14<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline)]
        public static Vector256<T> f15<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(c, and(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline)]
        public static Vector256<T> f16<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => select(a, nor(b,c), xor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline)]
        public static Vector256<T> f17<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => not(select(a, or(b,c), and(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline)]
        public static Vector256<T> f18<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline)]
        public static Vector256<T> f19<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline)]
        public static Vector256<T> f1a<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline)]
        public static Vector256<T> f1b<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => select(c, not(a), not(b));

        // a ? (b xnor c) : (b nand c)
        [MethodImpl(Inline)]
        public static Vector256<T> f97<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => select(c, xnor(b,c), nand(b,c));
    }

}

