//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Nats;

    public static partial class VectorizedOps
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> @false<T>(N256 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> @true<T>(N256 w)
            where T:unmanaged
                => vpattern.vones<T>(n256);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> @false<T>(Vector256<T> x)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> @true<T>(Vector256<T> x)
            where T:unmanaged
                => vpattern.vones<T>(n256);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> @false<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> @true<T>(Vector256<T> x, Vector256<T> y)
            where T:unmanaged
                => vpattern.vones<T>(n256);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> @false<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> @true<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T:unmanaged
                => vpattern.vones<T>(n256);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> identity<T>(Vector256<T> a)
            where T : unmanaged
                => a;

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> not<T>(Vector256<T> a)
            where T : unmanaged
                => gvec.vnot(a);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> and<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vand(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> nand<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vnand(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> or<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vor(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> nor<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vnor(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> xor<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vxor(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> xnor<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vxnor(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> left<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => a;

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> lnot<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => not(a);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> right<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => b;

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> rnot<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => not(b);

        [MethodImpl(Inline), NumericClosures(NumericKind.Integers)]
        public static Vector256<T> impl<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vimpl(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> nonimpl<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vnonimpl(a,b); 

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> cimpl<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vcimpl(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> cnonimpl<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vcnonimpl(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> xornot<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vxornot(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> sll<T>(Vector256<T> a, [Imm] byte count)
            where T : unmanaged
                => gvec.vsll<T>(a, count);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> srl<T>(Vector256<T> a, [Imm] byte count)
            where T : unmanaged
                => gvec.vsrl<T>(a, count);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> rotl<T>(Vector256<T> a, [Imm] byte count)
            where T : unmanaged
                => gvec.vrotl<T>(a, count);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> rotr<T>(Vector256<T> a, [Imm] byte count)
            where T : unmanaged
                => gvec.vrotr<T>(a, count);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> inc<T>(Vector256<T> a)
            where T : unmanaged
                => gvec.vinc(a);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> dec<T>(Vector256<T> a)
            where T : unmanaged
                => gvec.vdec(a);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> negate<T>(Vector256<T> a)
            where T : unmanaged
                => gvec.vnegate<T>(a);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> add<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vadd(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> sub<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vsub(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> equals<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.veq(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static bit same<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vtestc(gvec.veq(a,b));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static Vector256<T> lt<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vlt(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static Vector256<T> gt<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vgt(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static Vector256<T> max<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vmax(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> select<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vselect(a,b,c);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f00<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f01<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
            => nor(a, or(b,c));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f02<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(c, nor(b,a));
 
         // b nor a
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f03<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(b,a);

       // b and (a nor c)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f04<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f05<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(c,a);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f06<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(a), xor(b,c));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f07<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(a, and(b,c));
        
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f08<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(and(not(a),b), c);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f09<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(a, xor(b,c));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f0a<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f0b<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(a), or(not(b),  c));   

        // b and (not a)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f0c<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(b, not(a));

        // not a and (b or (c xor 1))
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f0d<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(a), or(b, not(c)));

        // not a and (b or c)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f0e<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f0f<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => not(a);

        // a and (b nor c)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f10<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(a, nor(b, c));
        
        // c nor b
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f11<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f12<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f13<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f14<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f15<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => nor(c, and(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f16<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => select(a, nor(b,c), xor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f17<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => not(select(a, or(b,c), and(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f18<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f19<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f1a<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f1b<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => select(c, not(a), not(b));

        // a ? (b xnor c) : (b nand c)
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> f97<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => select(c, xnor(b,c), nand(b,c));
    }
}