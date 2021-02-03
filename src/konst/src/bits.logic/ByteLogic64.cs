//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.CompilerServices.Unsafe;

    using static Part;
    using static memory;
    using static Buffers;

    using L = ScalarBitLogic;

    public readonly struct ByteLogic64
    {
        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ulong read<T>(W64 w, in T src)
            => ref As<T,ulong>(ref AsRef(in src));

        [MethodImpl(Inline), Not]
        public static void not(in byte a, ref byte dst)
            => write(L.not(read(w, a)), ref dst);

        [MethodImpl(Inline), And]
        public static void and(in byte a, in byte b, ref byte dst)
            => write(L.and(read(w,a), read(w,b)), ref dst);

        [MethodImpl(Inline), Nand]
        public static void nand(in byte a, in byte b, ref byte dst)
            => write(L.nand(read(w,a), read(w,b)), ref dst);

        [MethodImpl(Inline), Or]
        public static void or(in byte a, in byte b, ref byte dst)
            => write(L.or(read(w,a), read(w,b)), ref dst);

        [MethodImpl(Inline), Nor]
        public static void nor(in byte a, in byte b, ref byte dst)
            => write(L.nor(read(w,a), read(w,b)), ref dst);

        [MethodImpl(Inline), Xor]
        public static void xor(in byte a, in byte b, ref byte dst)
            => write(L.xor(read(w,a), read(w,b)), ref dst);

        [MethodImpl(Inline), Xnor]
        public static void xnor(in byte a, in byte B, ref byte dst)
            => write(L.xnor(read(w,a), read(w,B)), ref dst);

        [MethodImpl(Inline), NonImpl]
        public static void nonimpl(in byte a, in byte B, ref byte dst)
            => write(L.nonimpl(read(w,a), read(w,B)), ref dst);

        [MethodImpl(Inline), Impl]
        public static void impl(in byte a, in byte b, ref byte dst)
            => write(L.impl(read(w,a), read(w,b)), ref dst);

        [MethodImpl(Inline), CImpl]
        public static void cimpl(in byte a, in byte b, ref byte dst)
            => write(L.cimpl(read(w,a), read(w,b)), ref dst);

        [MethodImpl(Inline), CNonImpl]
        public static void cnonimpl(in byte a, in byte B, ref byte dst)
            => write(L.cnonimpl(read(w,a), read(w,B)), ref dst);

        [MethodImpl(Inline), XorNot]
        public static void xornot(in byte a, in byte b, ref byte dst)
            => write(L.xor(read(w,a), L.not(read(w,b))), ref dst);

        [MethodImpl(Inline), TestZ]
        public static bit testz(in byte a, in byte b)
            => BitLogic.testz(read(w,a), read(w,b));

        [MethodImpl(Inline), TestC]
        public static bit testc(in byte a, in byte b)
            => BitLogic.testc(read(w,a), read(w,b));

        [MethodImpl(Inline), TestC]
        public static bit testc(in byte a)
            => BitLogic.testc(read(w,a));

        [MethodImpl(Inline), Select]
        public static void select(in byte a, in byte b, in byte c, ref byte dst)
            => write(L.select(read(w,a), read(w,b), read(w,c)), ref dst);

        static W64 w => default;
    }
}