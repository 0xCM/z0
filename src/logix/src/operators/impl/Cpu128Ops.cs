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

    [ApiHost("vector.ops")]
    public static partial class VectorizedOps
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> @false<T>(W128 w)
            where T : unmanaged
                => gvec.vfalse<T>(w);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> @false<T>(Vector128<T> x)
            where T : unmanaged
                => gvec.vfalse(x);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> @false<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => gvec.vfalse(x,y);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> @false<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
                => gvec.vfalse(x,y,z);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> @true<T>(N128 w)
            where T:unmanaged
                => gvec.vtrue<T>(w);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> @true<T>(Vector128<T> x)
            where T:unmanaged
                => gvec.vtrue<T>(x);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> @true<T>(Vector128<T> x, Vector128<T> y)
            where T:unmanaged
                => gvec.vtrue<T>(x,y);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> @true<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T:unmanaged
                => gvec.vtrue<T>(x,y,z);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> identity<T>(Vector128<T> a)
            where T : unmanaged
                => gvec.videntity(a);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> not<T>(Vector128<T> a)
            where T : unmanaged
                => gvec.vnot(a);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> and<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vand(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> nand<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vnand(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> or<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vor(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> nor<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vnor(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> xor<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vxor(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> xnor<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vxnor(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> left<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vleft(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> right<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vright(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> lnot<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vlnot(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> rnot<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vrnot(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> impl<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vimpl(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> nonimpl<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                =>  gvec.vnonimpl(a,b); 

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> cimpl<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vcimpl(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> cnonimpl<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vcnonimpl(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> xornot<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vxornot(a,b);

        [MethodImpl(Inline), Op, Closures(NumericKind.UnsignedInts)]
        public static Vector128<T> sll<T>(Vector128<T> a, [Imm] byte offset)
            where T : unmanaged
                => gvec.vsll<T>(a, offset);

        [MethodImpl(Inline), Op, Closures(NumericKind.UnsignedInts)]
        public static Vector128<T> srl<T>(Vector128<T> a, [Imm] byte offset)
            where T : unmanaged
                => gvec.vsrl<T>(a, offset);

        [MethodImpl(Inline), Op, Closures(NumericKind.UnsignedInts)]
        public static Vector128<T> rotl<T>(Vector128<T> a, [Imm] byte offset)
            where T : unmanaged
                => gvec.vrotl<T>(a, offset);

        [MethodImpl(Inline), Op, Closures(NumericKind.UnsignedInts)]
        public static Vector128<T> rotr<T>(Vector128<T> a, [Imm] byte offset)
            where T : unmanaged
                => gvec.vrotr<T>(a, offset);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> inc<T>(Vector128<T> a)
            where T : unmanaged
                => gvec.vinc(a);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> dec<T>(Vector128<T> a)
            where T : unmanaged
                => gvec.vdec(a);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> negate<T>(Vector128<T> a)
            where T : unmanaged
                => gvec.vnegate<T>(a);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> add<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vadd(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> sub<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vsub(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> equals<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.veq(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static bit same<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vtestc(equals(a,b));

        [MethodImpl(Inline), Op, Closures(Integers& (~NumericKind.U64))]
        public static Vector128<T> lt<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vlt(a,b);

        [MethodImpl(Inline), Op, Closures(Integers& (~NumericKind.U64))]
        public static Vector128<T> gt<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vgt(a,b);

        [MethodImpl(Inline), Op, Closures(Integers& (~NumericKind.U64))]
        public static Vector128<T> max<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => gvec.vmax(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> select<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vselect(a,b,c);  

        // a nor (b or c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f01<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
            => gvec.vnor(a, gvec.vor(b,c));

        // c and (b nor a)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f02<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(c, gvec.vnor(b,a));
 
         // b nor a
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f03<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(b,a);

       // b and (a nor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f04<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(b, gvec.vnor(a,c));

        // c nor a
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f05<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f06<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vxor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f07<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(a, gvec.vand(b,c));

        // (not a and b) and c
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f08<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vand(gvec.vnot(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f09<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(a, gvec.vxor(b,c));

        // c and (not a)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0a<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(c, gvec.vnot(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0b<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vor(gvec.vnot(b),  c));   

        // b and (not a)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0c<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(b, gvec.vnot(a));

        // not a and (b or (c xor 1))
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0d<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vor(b, gvec.vnot(c)));

        // not a and (b or c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0e<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vor(b,c));

        // not a
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0f<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnot(a);

        // a and (b nor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f10<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(a, gvec.vnor(b, c));
        
        // c nor b
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f11<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f12<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(b), gvec.vxor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f13<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(b, gvec.vand(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f14<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(c), gvec.vxor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f15<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(c, gvec.vand(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f16<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vselect(a, gvec.vnor(b,c), gvec.vxor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f17<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnot(gvec.vselect(a, gvec.vor(b,c), gvec.vand(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f18<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vxor(a,b), gvec.vxor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f19<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vxor(gvec.vxor(b,c), gvec.vand(a, gvec.vand(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f1a<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnot(gvec.vand(gvec.vand(a,b), gvec.vxor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f1b<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vselect(c, gvec.vnot(a), gvec.vnot(b));

        // a ? (b xnor c) : (b nand c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f97<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vselect(c, gvec.vxnor(b,c), gvec.vnand(b,c));
    }
}