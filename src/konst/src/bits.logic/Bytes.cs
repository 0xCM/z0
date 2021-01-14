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
    using static Buffers;

    using L = BitLogic.Scalar;

    partial struct BitLogic
    {
        [ApiHost(ApiNames.BitLogicBytes, true)]
        public readonly struct Bytes
        {
            [MethodImpl(Inline), Not]
            public static void not(in byte a, ref byte dst)
                => write(L.not(read(w64, a)), ref dst);

            [MethodImpl(Inline), And]
            public static void and(in byte A, in byte B, ref byte dst)
                => write(L.and(read(w64,A), read(w64,B)), ref dst);

            [MethodImpl(Inline), Nand]
            public static void nand(in byte A, in byte B, ref byte dst)
                => write(L.nand(read(w64,A), read(w64,B)), ref dst);

            [MethodImpl(Inline), Or]
            public static void or(in byte A, in byte B, ref byte dst)
                => write(L.or(read(w64,A), read(w64,B)), ref dst);

            [MethodImpl(Inline), Nor]
            public static void nor(in byte A, in byte B, ref byte dst)
                => write(L.nor(read(w64,A), read(w64,B)), ref dst);

            [MethodImpl(Inline), Xor]
            public static void xor(in byte a, in byte b, ref byte dst)
                => write(L.xor(read(w64,a), read(w64,b)), ref dst);

            [MethodImpl(Inline), Xnor]
            public static void xnor(in byte a, in byte B, ref byte dst)
                => write(L.xnor(read(w64,a), read(w64,B)), ref dst);

            [MethodImpl(Inline), NonImpl]
            public static void nonimpl(in byte a, in byte B, ref byte dst)
                => write(L.nonimpl(read(w64,a), read(w64,B)), ref dst);

            [MethodImpl(Inline), Impl]
            public static void impl(in byte A, in byte B, ref byte dst)
                => write(L.impl(read(w64,A), read(w64,B)), ref dst);

            [MethodImpl(Inline), CImpl]
            public static void cimpl(in byte A, in byte B, ref byte dst)
                => write(L.cimpl(read(w64,A), read(w64,B)), ref dst);

            [MethodImpl(Inline), CNonImpl]
            public static void cnonimpl(in byte a, in byte B, ref byte dst)
                => write(L.cnonimpl(read(w64,a), read(w64,B)), ref dst);

            [MethodImpl(Inline), XorNot]
            public static void xornot(in byte a, in byte b, ref byte dst)
                => write(L.xor(read(w64,a), L.not(read(w64,b))), ref dst);

            [MethodImpl(Inline), TestZ]
            public static bit testz(in byte a, in byte b)
                => BitLogic.testz(read(w64,a), read(w64,b));

            [MethodImpl(Inline), TestC]
            public static bit testc(in byte a, in byte b)
                => BitLogic.testc(read(w64,a), read(w64,b));

            [MethodImpl(Inline), TestC]
            public static bit testc(in byte a)
                => BitLogic.testc(read(w64,a));

            [MethodImpl(Inline), Select]
            public static void select(in byte a, in byte b, in byte c, ref byte dst)
                => write(L.select(read(w64,a), read(w64,b), read(w64,c)), ref dst);
        }
    }
}