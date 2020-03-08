//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    // using static Root;
    // using static Nats;
    using static As;
    using static Root;
    using static Nats;

    static partial class vblock
    {
        
    }

    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    static class BitSquare
    {
        static N256 n => n256;

        [MethodImpl(Inline)]
        public static void not<T>(in T A, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               not(in uint8(in A), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.not(n, in A, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.not(n, 4, 8, in A, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.not(n, 16, 4, in A, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void select<T>(in T A, in T B, in T C, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               select(in uint8(in A), in uint8(in B), in uint8(in C), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.select(n, in A, in B, in C, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.select(n, 4, 8, in A, in B, in C, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.select(n, 16, 4, in A, in B, in C, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void and<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               and(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.and(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.and(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.and(n, 16, 4, in A, in B, ref Z);
            else
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        public static void nand<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               nand(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.nand(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.nand(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.nand(n, 16, 4, in A, in B, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void or<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               or(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.or(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.or(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.or(n, 16, 4, in A, in B, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void nor<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               nor(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.nor(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.nor(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.nor(n, 16, 4, in A, in B, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void xor<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               xor(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.xor(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.xor(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.xor(n, 16, 4, in A, in B, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void xnor<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               xnor(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.xnor(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.xnor(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.xnor(n, 16, 4, in A, in B, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void impl<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               impl(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.impl(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.impl(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.impl(n, 16, 4, in A, in B, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void nonimpl<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               nonimpl(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.nonimpl(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.nonimpl(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.nonimpl(n, 16, 4, in A, in B, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void cimpl<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               cimpl(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.cimpl(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.cimpl(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.cimpl(n, 16, 4, in A, in B, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void cnonimpl<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               cnonimpl(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.cnonimpl(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.cnonimpl(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.cnonimpl(n, 16, 4, in A, in B, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void xornot<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               xornot(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                vblock.xornot(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                vblock.xornot(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                vblock.xornot(n, 16, 4, in A, in B, ref Z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(in T A, in T B)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return testz(in uint8(in A), in uint8(in B));
            else if(typeof(T) == typeof(ushort))
               return vblock.testz(n, in A, in B);
            else if(typeof(T) == typeof(uint))
               return vblock.testz(n, 4, 8, in uint32(in A), in uint32(in B));
            else if(typeof(T) == typeof(ulong))
               return vblock.testz(n, 16, 4, in uint64(in A), in uint64(in B));
            else
                throw unsupported<T>();
        }
        
        [MethodImpl(Inline)]
        public static bit testc<T>(in T A)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return testc(in uint8(in A));
            else if(typeof(T) == typeof(ushort))
               return vblock.vtestc(n, in A);
            else if(typeof(T) == typeof(uint))
               return vblock.testc(n, 4, 8, in A);
            else if(typeof(T) == typeof(ulong))
                return vblock.testc(n, 16, 4, in A);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bit testc<T>(in T A, in T B)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return testc(in uint8(in A),in uint8(in B));
            else if(typeof(T) == typeof(ushort))
               return vblock.vtestc(n, in A,in B);
            else if(typeof(T) == typeof(uint))
               return vblock.testc(n, 4, 8, in A, in B);
            else if(typeof(T) == typeof(ulong))
                return vblock.testc(n, 16, 4, in A, in B);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void not(in byte A, ref byte Z)
            => store64(gmath.not(Bytes.read64(A)), ref Z);

        [MethodImpl(Inline)]
        static void select(in byte A, in byte B, in byte C, ref byte Z)
            => store64(gmath.select(Bytes.read64(A), Bytes.read64(B), Bytes.read64(C)), ref Z);

        [MethodImpl(Inline)]
        static void and(in byte A, in byte B, ref byte Z)
            => store64(gmath.and(Bytes.read64(A), Bytes.read64(B)), ref Z);

        [MethodImpl(Inline)]
        static void nand(in byte A, in byte B, ref byte Z)
            => store64(gmath.nand(Bytes.read64(A), Bytes.read64(B)), ref Z);

        [MethodImpl(Inline)]
        static void or(in byte A, in byte B, ref byte Z)
            => store64(gmath.or(Bytes.read64(A), Bytes.read64(B)), ref Z);

        [MethodImpl(Inline)]
        static void nor(in byte A, in byte B, ref byte Z)
            => store64(gmath.nor(Bytes.read64(A), Bytes.read64(B)), ref Z);

        [MethodImpl(Inline)]
        static void xor(in byte A, in byte B, ref byte Z)
            => store64(gmath.xor(Bytes.read64(A), Bytes.read64(B)), ref Z);

        [MethodImpl(Inline)]
        static void xnor(in byte A, in byte B, ref byte Z)
            => store64(gmath.xnor(Bytes.read64(A), Bytes.read64(B)), ref Z);

        [MethodImpl(Inline)]
        static void nonimpl(in byte A, in byte B, ref byte Z)
            => store64(gmath.nonimpl(Bytes.read64(A), Bytes.read64(B)), ref Z);

        [MethodImpl(Inline)]
        static void impl(in byte A, in byte B, ref byte Z)
            => store64(gmath.impl(Bytes.read64(A), Bytes.read64(B)), ref Z);

        [MethodImpl(Inline)]
        static void cimpl(in byte A, in byte B, ref byte Z)
            => store64(gmath.cimpl(Bytes.read64(A), Bytes.read64(B)), ref Z);

        [MethodImpl(Inline)]
        static void cnonimpl(in byte A, in byte B, ref byte Z)
            => store64(gmath.cnonimpl(Bytes.read64(A), Bytes.read64(B)), ref Z);

        [MethodImpl(Inline)]
        static void xornot(in byte A, in byte B, ref byte Z)
            => store64(gmath.xor(Bytes.read64(in A), gmath.not(Bytes.read64(in B))), ref Z);

        [MethodImpl(Inline)]
        static bit testz(in byte A, in byte B)
            => dinx.testz(Bytes.read64(in A), Bytes.read64(in B));

        [MethodImpl(Inline)]
        static bit testc(in byte A, in byte B)
            => dinx.testc(Bytes.read64(in A),Bytes.read64(in B));

        [MethodImpl(Inline)]
        static bit testc(in byte A)
            => dinx.testc(Bytes.read64(in A));

    }
}