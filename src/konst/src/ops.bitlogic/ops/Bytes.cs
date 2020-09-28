//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static memory;

    using L = BitLogic.Scalar;

    partial struct BitLogic
    {
        [ApiHost("bitlogic.bytes")]
        public readonly struct Bytes
        {
            [MethodImpl(Inline), Not]
            public static void not(in byte A, ref byte Z)
                => write(L.not(read(w64, A)), ref Z);

            [MethodImpl(Inline), Select]
            public static void select(in byte A, in byte B, in byte C, ref byte Z)
                => write(L.select(read(w64,A), read(w64,B), read(w64,C)), ref Z);

            [MethodImpl(Inline), And]
            public static void and(in byte A, in byte B, ref byte Z)
                => write(L.and(read(w64,A), read(w64,B)), ref Z);

            [MethodImpl(Inline), Nand]
            public static void nand(in byte A, in byte B, ref byte Z)
                => write(L.nand(read(w64,A), read(w64,B)), ref Z);

            [MethodImpl(Inline), Or]
            public static void or(in byte A, in byte B, ref byte Z)
                => write(L.or(read(w64,A), read(w64,B)), ref Z);

            [MethodImpl(Inline), Nor]
            public static void nor(in byte A, in byte B, ref byte Z)
                => write(L.nor(read(w64,A), read(w64,B)), ref Z);

            [MethodImpl(Inline), Xor]
            public static void xor(in byte A, in byte B, ref byte Z)
                => write(L.xor(read(w64,A), read(w64,B)), ref Z);

            [MethodImpl(Inline), Xnor]
            public static void xnor(in byte A, in byte B, ref byte Z)
                => write(L.xnor(read(w64,A), read(w64,B)), ref Z);

            [MethodImpl(Inline), NonImpl]
            public static void nonimpl(in byte A, in byte B, ref byte Z)
                => write(L.nonimpl(read(w64,A), read(w64,B)), ref Z);

            [MethodImpl(Inline), Impl]
            public static void impl(in byte A, in byte B, ref byte Z)
                => write(L.impl(read(w64,A), read(w64,B)), ref Z);

            [MethodImpl(Inline), CImpl]
            public static void cimpl(in byte A, in byte B, ref byte Z)
                => write(L.cimpl(read(w64,A), read(w64,B)), ref Z);

            [MethodImpl(Inline), CNonImpl]
            public static void cnonimpl(in byte A, in byte B, ref byte Z)
                => write(L.cnonimpl(read(w64,A), read(w64,B)), ref Z);

            [MethodImpl(Inline), XorNot]
            public static void xornot(in byte A, in byte B, ref byte Z)
                => write(L.xor(read(w64,A), L.not(read(w64,B))), ref Z);

            [MethodImpl(Inline), TestZ]
            public static Bit32 testz(in byte A, in byte B)
                => z.testz(read(w64,A), read(w64,B));

            [MethodImpl(Inline), TestC]
            public static Bit32 testc(in byte A, in byte B)
                => z.testc(read(w64,A),read(w64,B));

            [MethodImpl(Inline), TestC]
            public static Bit32 testc(in byte A)
                => z.testc(read(w64,A));
        }

    }
}