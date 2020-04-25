//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;    
    using static Memories;

    public static partial class VectorizedOps
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> @false<T>(W256 w)
            where T : unmanaged
                => gvec.vfalse<T>(w);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> @false<T>(Vector256<T> x)
            where T : unmanaged
                => gvec.vfalse<T>(x);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> @false<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => gvec.vfalse<T>(x,y);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> @false<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T : unmanaged
                => gvec.vfalse<T>(x,y,z);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> @true<T>(N256 w)
            where T:unmanaged
                => gvec.vtrue<T>(w);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> @true<T>(Vector256<T> x)
            where T:unmanaged
                => gvec.vtrue<T>(x);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> @true<T>(Vector256<T> x, Vector256<T> y)
            where T:unmanaged
                => gvec.vtrue<T>(x,y);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> @true<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T:unmanaged
                => gvec.vtrue<T>(x,y,z);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> identity<T>(Vector256<T> a)
            where T : unmanaged
                => gvec.videntity(a);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> not<T>(Vector256<T> a)
            where T : unmanaged
                => gvec.vnot(a);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> and<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vand(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> nand<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vnand(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> or<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vor(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> nor<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vnor(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> xor<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vxor(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> xnor<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vxnor(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> left<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vleft(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> lnot<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vlnot(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> right<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vright(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> rnot<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vrnot(a,b);

        [MethodImpl(Inline), Closures(Integers)]
        public static Vector256<T> impl<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vimpl(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> nonimpl<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vnonimpl(a,b); 

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> cimpl<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vcimpl(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> cnonimpl<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vcnonimpl(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> xornot<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vxornot(a,b);

        [MethodImpl(Inline), Op, Closures(NumericKind.UnsignedInts)]
        public static Vector256<T> sll<T>(Vector256<T> a, [Imm] byte count)
            where T : unmanaged
                => gvec.vsll<T>(a, count);

        [MethodImpl(Inline), Op, Closures(NumericKind.UnsignedInts)]
        public static Vector256<T> srl<T>(Vector256<T> a, [Imm] byte count)
            where T : unmanaged
                => gvec.vsrl<T>(a, count);

        [MethodImpl(Inline), Op, Closures(NumericKind.UnsignedInts)]
        public static Vector256<T> rotl<T>(Vector256<T> a, [Imm] byte count)
            where T : unmanaged
                => gvec.vrotl<T>(a, count);

        [MethodImpl(Inline), Op, Closures(NumericKind.UnsignedInts)]
        public static Vector256<T> rotr<T>(Vector256<T> a, [Imm] byte count)
            where T : unmanaged
                => gvec.vrotr<T>(a, count);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> inc<T>(Vector256<T> a)
            where T : unmanaged
                => gvec.vinc(a);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> dec<T>(Vector256<T> a)
            where T : unmanaged
                => gvec.vdec(a);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> negate<T>(Vector256<T> a)
            where T : unmanaged
                => gvec.vnegate<T>(a);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> add<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vadd(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> sub<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vsub(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> equals<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.veq(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static bit same<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vtestc(gvec.veq(a,b));

        [MethodImpl(Inline), Op, Closures(Integers& (~NumericKind.U64))]
        public static Vector256<T> lt<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vlt(a,b);

        [MethodImpl(Inline), Op, Closures(Integers& (~NumericKind.U64))]
        public static Vector256<T> gt<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vgt(a,b);

        [MethodImpl(Inline), Op, Closures(Integers& (~NumericKind.U64))]
        public static Vector256<T> max<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vmax(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> select<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vselect(a,b,c);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f00<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f01<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
            => gvec.vnor(a, gvec.vor(b,c));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f02<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(c, gvec.vnor(b,a));
 
         // b nor a
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f03<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vnor(b,a);

       // b and (a nor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f04<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(b, gvec.vnor(a,c));

        // c nor a
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f05<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vnor(c,a);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f06<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vxor(b,c));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f07<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vnor(a, gvec.vand(b,c));
        
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f08<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vand(gvec.vnot(a),b), c);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f09<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vnor(a, gvec.vxor(b,c));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f0a<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(c, gvec.vnot(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f0b<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vor(gvec.vnot(b),  c));   

        // b and (not a)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f0c<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(b, gvec.vnot(a));

        // not a and (b or (c xor 1))
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f0d<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vor(b, gvec.vnot(c)));

        // not a and (b or c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f0e<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vor(b,c));

        // not a
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f0f<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vnot(a);

        // a and (b nor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f10<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(a, gvec.vnor(b, c));
        
        // c nor b
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f11<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vnor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f12<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(b), gvec.vxor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f13<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vnor(b, gvec.vand(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f14<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(c), gvec.vxor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f15<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vnor(c, gvec.vand(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f16<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vselect(a, gvec.vnor(b,c), gvec.vxor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f17<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vnot(gvec.vselect(a, gvec.vor(b,c), gvec.vand(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f18<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vxor(a,b), gvec.vxor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f19<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vxor(gvec.vxor(b,c), gvec.vand(a, gvec.vand(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f1a<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vnot(gvec.vand(gvec.vand(a,b), gvec.vxor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f1b<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vselect(c, gvec.vnot(a), gvec.vnot(b));

        // a ? (b xnor c) : (b nand c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> f97<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c)
            where T : unmanaged
                => gvec.vselect(c, gvec.vxnor(b,c), gvec.vnand(b,c));
    }
}