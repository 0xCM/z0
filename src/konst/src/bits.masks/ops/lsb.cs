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
    using static MaskLiterals;

    partial class BitMasks
    {
        [MethodImpl(Inline)]
        public static LsbMask<F,D,T> LsbSpec<F,D,T>(F f = default, D d = default, T t = default)
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline),Op]
        public static byte lsb8f(byte density)
            => (byte)(byte.MaxValue >> (8 - density));

        /// <summary>
        /// [00000000 00000001]
        /// The least bit of each 16-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline) ,Op]
        public static ulong lsb64(N16 f, N1 d)
            => Lsb64x16x1;

        /// <summary>
        /// [00000000 00000000 00000000 0000001]
        /// The least bit is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask data type representative</param>
        [MethodImpl(Inline) ,Op]
        public static uint lsb(N32 f, N1 d, uint t)
            => Lsb32x32x1;

        /// <summary>
        /// [00000000 00000000 00000000 0000001]
        /// The least bit of each 32-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask data type representative</param>
        [MethodImpl(Inline) ,Op]
        public static ulong lsb64(N32 f, N1 d, ulong t)
            => Lsb64x32x1;

        /// <summary>
        /// [01 01 ... 01]
        /// Defines a width-variant LSB pattern that repeats every 2 bits with density 1
        /// </summary>
        /// <param name="w">The pattern width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="N">The width type</typeparam>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Closures(Closure), Naturals(4,6,8,10,12,14,16,18,32,64)]
        public static T lsb<N,T>(N w, N2 f, N1 d, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => convert<ulong,T>(lsb(w,f,d));

        /// <summary>
        /// [001 001 ... 001]
        /// Defines a width-variant LSB pattern that repeats every 3 bits with density 1
        /// </summary>
        /// <param name="w">The pattern width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="N">The width type</typeparam>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<N,T>(N w, N3 f, N1 d, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => convert<ulong,T>(lsb_3x1_a(w,f,d));

        /// <summary>
        /// [00....01]
        /// The least bit, relative to the data type, is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lsb<T>(N1 f, N1 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x1x1);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x16x1);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x32x1);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x64x1);
            else
                throw no<T>();
        }

        /// <summary>
        /// [01]
        /// The least bit of each 2-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant bit out of each two bits is enabled</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lsb<T>(N2 f, N1 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x2x1);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x2x1);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x2x1);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x2x1);
            else
                throw no<T>();
        }

        /// <summary>
        /// [0001]
        /// The least bit of each 4-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant bit out of each four bits is enabled</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lsb<T>(N4 f, N1 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x4x1);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x4x1);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x4x1);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x4x1);
            else
                throw no<T>();
        }

        /// <summary>
        /// [00000001]
        /// The least bit of each 8-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lsb<T>(N8 f, N1 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x1x1);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x8x1);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x8x1);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x8x1);
            else
                throw no<T>();
        }

        /// <summary>
        /// [00000000 00000001]
        /// The least bit of each 16-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lsb<T>(N16 f, N1 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return default;
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x16x1);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x16x1);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x16x1);
            else
                throw no<T>();
        }

        /// <summary>
        /// [00000011]
        /// The least 2 bits of each 8-bits are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lsb<T>(N8 f, N2 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x8x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x8x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x8x2);
            else
                throw no<T>();
        }

        /// <summary>
        /// [00000111]
        /// The least 3 bits of each 8-bits are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lsb<T>(N8 f, N3 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x8x3);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x8x3);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x8x3);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x8x3);
            else
                throw no<T>();
        }

        /// <summary>
        /// [00001111]
        /// The least 4 bits of each 8-bits are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lsb<T>(N8 f, N4 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x8x4);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x8x4);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x8x4);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x8x4);
            else
                throw no<T>();
        }

        /// <summary>
        /// [00011111]
        /// The least 5 bits of each 8-bits are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lsb<T>(N8 f, N5 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x8x5);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x8x5);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x8x5);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x8x5);
            else
                throw no<T>();
        }

        /// <summary>
        /// [00111111]
        /// The least 6 bits of each 8-bits are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lsb<T>(N8 f, N6 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x8x6);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x8x6);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x8x6);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x8x6);
            else
                throw no<T>();
        }

        /// <summary>
        /// [01111111]
        /// The least 7 bits of each 8-bits are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T lsb<T>(N8 f, N7 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x8x7);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x8x7);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x8x7);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x8x7);
            else
                throw no<T>();
        }

        /// <summary>
        /// [00000001]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(LsbMask<N1,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [01]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(LsbMask<N2,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [0001]
        /// The least bit of each 4-bit segment is enabled
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(LsbMask<N4,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00000001]
        /// The least bit of each 8-bit segment is enabled
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(LsbMask<N8,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00000000 00000001]
        /// The least bit of each 16-bit segment is enabled
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(LsbMask<N16,N1,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00000011]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(LsbMask<N8,N2,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [000000111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(LsbMask<N8,N3,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00000111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(LsbMask<N8,N4,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00011111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(LsbMask<N8,N5,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [00111111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(LsbMask<N8,N6,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        /// <summary>
        /// [01111111]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(LsbMask<N8,N7,T> spec)
            where T : unmanaged
                => lsb(spec.f,spec.d,spec.t);

        [MethodImpl(Inline)]
        static ulong lsb<W>(W w, N2 f, N1 d)
            where W : unmanaged, ITypeNat
        {
            if(typeof(W) == typeof(N4))
                return MaskLiterals.Lsb4x2x1;
            else if(typeof(W) == typeof(N6))
                return MaskLiterals.Lsb6x2x1;
            else if(typeof(W) == typeof(N8))
                return MaskLiterals.Lsb8x2x1;
            else if(typeof(W) == typeof(N10))
                return MaskLiterals.Lsb10x2x1;
            else if(typeof(W) == typeof(N12))
                return MaskLiterals.Lsb12x2x1;
            else if(typeof(W) == typeof(N14))
                return MaskLiterals.Lsb14x2x1;
            else if(typeof(W) == typeof(N16))
                return MaskLiterals.Lsb16x2x1;
            else if(typeof(W) == typeof(N18))
                return MaskLiterals.Lsb18x2x1;
            else if(typeof(W) == typeof(N32))
                return MaskLiterals.Lsb32x2x1;
            else if(typeof(W) == typeof(N64))
                return MaskLiterals.Lsb64x2x1;
            else
                throw no<W>();
        }

        [MethodImpl(Inline)]
        static ulong lsb_3x1_a<W>(W w, N3 f, N1 d)
            where W : unmanaged, ITypeNat
        {
            if(typeof(W) == typeof(N6))
                return MaskLiterals.Lsb6x3x1;
            else if(typeof(W) == typeof(N9))
                return MaskLiterals.Lsb9x3x1;
            else if(typeof(W) == typeof(N12))
                return MaskLiterals.Lsb12x3x1;
            else if(typeof(W) == typeof(N15))
                return MaskLiterals.Lsb15x3x1;
            else if(typeof(W) == typeof(N18))
                return MaskLiterals.Lsb18x3x1;
            else if(typeof(W) == typeof(N21))
                return MaskLiterals.Lsb21x3x1;
            else if(typeof(W) == typeof(N24))
                return MaskLiterals.Lsb24x3x1;
            else if(typeof(W) == typeof(N27))
                return MaskLiterals.Lsb27x3x1;
            else if(typeof(W) == typeof(N30))
                return MaskLiterals.Lsb30x3x1;
            else
                return lsb_3x1_b(w,f,d);
        }

        [MethodImpl(Inline)]
        static ulong lsb_3x1_b<W>(W w, N3 f, N1 d)
            where W : unmanaged, ITypeNat
        {
            if(typeof(W) == typeof(N33))
                return MaskLiterals.Lsb33x3x1;
            else if(typeof(W) == typeof(N36))
                return MaskLiterals.Lsb36x3x1;
            else if(typeof(W) == typeof(N39))
                return MaskLiterals.Lsb39x3x1;
            else if(typeof(W) == typeof(N41))
                return MaskLiterals.Lsb41x3x1;
            else if(typeof(W) == typeof(N44))
                return MaskLiterals.Lsb44x3x1;
            else if(typeof(W) == typeof(N48))
                return MaskLiterals.Lsb48x3x1;
            else if(typeof(W) == typeof(N51))
                return MaskLiterals.Lsb51x3x1;
            else
                return lsb_3x1_c(w,f,d);
        }

        [MethodImpl(Inline)]
        static ulong lsb_3x1_c<W>(W w, N3 f, N1 d)
            where W : unmanaged, ITypeNat
        {
            if(typeof(W) == typeof(N54))
                return MaskLiterals.Lsb54x3x1;
            else if(typeof(W) == typeof(N57))
                return MaskLiterals.Lsb57x3x1;
            else if(typeof(W) == typeof(N60))
                return MaskLiterals.Lsb60x3x1;
            else if(typeof(W) == typeof(N63))
                return MaskLiterals.Lsb63x3x1;
            else
                 throw no<W>();
       }
    }
}