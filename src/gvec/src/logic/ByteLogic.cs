//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed;
    using static memory;

    [ApiHost]
    public class ByteLogic : IApiHost<ByteLogic>
    {
        [MethodImpl(Inline), Not]
        public static void not(in byte A, ref byte Z)
            => store64(gmath.not(read64(A)), ref Z);

        [MethodImpl(Inline), Select]
        public static void select(in byte A, in byte B, in byte C, ref byte Z)
            => store64(gmath.select(read64(A), read64(B), read64(C)), ref Z);

        [MethodImpl(Inline), And]
        public static void and(in byte A, in byte B, ref byte Z)
            => store64(gmath.and(read64(A), read64(B)), ref Z);

        [MethodImpl(Inline), Nand]
        public static void nand(in byte A, in byte B, ref byte Z)
            => store64(gmath.nand(read64(A), read64(B)), ref Z);

        [MethodImpl(Inline), Or]
        public static void or(in byte A, in byte B, ref byte Z)
            => store64(gmath.or(read64(A), read64(B)), ref Z);

        [MethodImpl(Inline), Nor]
        public static void nor(in byte A, in byte B, ref byte Z)
            => store64(gmath.nor(read64(A), read64(B)), ref Z);

        [MethodImpl(Inline), Xor]
        public static void xor(in byte A, in byte B, ref byte Z)
            => store64(gmath.xor(read64(A), read64(B)), ref Z);

        [MethodImpl(Inline), Xnor]
        public static void xnor(in byte A, in byte B, ref byte Z)
            => store64(gmath.xnor(read64(A), read64(B)), ref Z);

        [MethodImpl(Inline), NonImpl]
        public static void nonimpl(in byte A, in byte B, ref byte Z)
            => store64(gmath.nonimpl(read64(A), read64(B)), ref Z);

        [MethodImpl(Inline), Impl]
        public static void impl(in byte A, in byte B, ref byte Z)
            => store64(gmath.impl(read64(A), read64(B)), ref Z);

        [MethodImpl(Inline), CImpl]
        public static void cimpl(in byte A, in byte B, ref byte Z)
            => store64(gmath.cimpl(read64(A), read64(B)), ref Z);

        [MethodImpl(Inline), CNonImpl]
        public static void cnonimpl(in byte A, in byte B, ref byte Z)
            => store64(gmath.cnonimpl(read64(A), read64(B)), ref Z);

        [MethodImpl(Inline), XorNot]
        public static void xornot(in byte A, in byte B, ref byte Z)
            => store64(gmath.xor(read64(in A), gmath.not(read64(in B))), ref Z);

        [MethodImpl(Inline), TestZ]
        public static bit testz(in byte A, in byte B)
            => dvec.testz(read64(in A), read64(in B));

        [MethodImpl(Inline), TestC]
        public static bit testc(in byte A, in byte B)
            => dvec.testc(read64(in A),read64(in B));

        [MethodImpl(Inline), TestC]
        public static bit testc(in byte A)
            => dvec.testc(read64(in A));        
    }
}