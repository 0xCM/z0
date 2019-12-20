//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;

    using static zfunc;

    using static BitMasks;

    public static partial class BitMask
    {                
        /// <summary>
        /// [00110011]    
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static T even<T>(N2 f, N2 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Even8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Even16x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Even32x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Even64x2);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [11001100]    
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static T odd<T>(N2 f, N2 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Odd8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Odd16x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Odd32x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Odd64x2);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [00000001]    
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant bit, relative to the data type, is enabled</remarks>
        [MethodImpl(Inline)]
        public static T lsb<T>(N1 f = default, N1 d = default, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [01 01 ... 01]
        /// </summary>
        /// <param name="w">The pattern width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="W">The width type</typeparam>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a width-variant LSB pattern that repeats every 2 bits with density 1</remarks>
        [MethodImpl(Inline)]
        public static T lsb<W,T>(W w, N2 f, N1 d, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => convert<ulong,T>(lsb(w,f,d));

        /// <summary>
        /// [01]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant bit out of every two bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static T lsb<T>(N2 f, N1 d = default, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x2);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [0001]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant bit out of every four bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static T lsb<T>(N4 f, N1 d = default, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8x4);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x4);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x4);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x4);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [00000001]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant bit out of every eight bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static T lsb<T>(N8 f, N1 d = default, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Lsb8);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16x8);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x8);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x8);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [00000000 00000001]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant bit out of every 16 bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static T lsb<T>(N16 f, N1 d = default, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return default;
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Lsb16);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Lsb32x16);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Lsb64x16);
            else 
                throw unsupported<T>();

        }

        /// <summary>
        /// [00000011]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant 2 bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
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
                throw unsupported<T>();
        }

        /// <summary>
        /// [00000111]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant 3 bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
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
                throw unsupported<T>();
        }

        /// <summary>
        /// [00001111]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant 4 bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
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
                throw unsupported<T>();
        }

        /// <summary>
        /// [00011111]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant 5 bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
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
                throw unsupported<T>();
        }

        /// <summary>
        /// [00111111]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant 6 bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
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
                throw unsupported<T>();
        }

        /// <summary>
        /// [01111111]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant 7 bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
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
                throw unsupported<T>();
        }

        /// <summary>
        /// [1000...0000]    
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask data type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the most significant bit, relative to the data type, is enabled</remarks>
        [MethodImpl(Inline)]
        public static T msb<T>(N1 f = default, N1 d = default, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Msb8);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Msb16);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Msb32);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Msb64);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [10]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the most significant bit out of every two bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static T msb<T>(N2 f, N1 d = default, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Msb8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Msb16x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Msb32x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Msb64x2);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [10001000]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the most significant bit out of every four bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static T msb<T>(N4 f, N1 d = default, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Msb8x4);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Msb16x4);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Msb32x4);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Msb64x4);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [10000000]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the most significant bit out of every eight bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N1 d = default, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Msb8);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Msb16x8);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Msb32x8);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Msb64x8);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [10000000 00000000]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the most significant bit out of every 16 bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static T msb<T>(N16 f, N1 d = default, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return default;
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Msb16);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Msb32x16);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Msb64x16);
            else 
                throw unsupported<T>();
        }


        /// <summary>
        /// [11000000]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the 2 most significant bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N2 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Msb8x8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Msb16x8x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Msb32x8x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Msb64x8x2);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [11100000]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the 3 most significant bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N3 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Msb8x8x3);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Msb16x8x3);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Msb32x8x3);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Msb64x8x3);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [11110000]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the 4 most significant bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N4 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Msb8x8x4);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Msb16x8x4);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Msb32x8x4);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Msb64x8x4);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [11111000]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the 5 most significant bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N5 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Msb8x8x5);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Msb16x8x5);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Msb32x8x5);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Msb64x8x5);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [11111100]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the 6 most significant bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N6 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Msb8x8x6);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Msb16x8x6);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Msb32x8x6);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Msb64x8x6);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [11111110]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the 7 most significant bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N7 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Msb8x8x7);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Msb16x8x7);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Msb32x8x7);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Msb64x8x7);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [10000001]
        /// </summary>
        /// <param name="f">The frequency selector</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>JSB := msb | lsb (8x1)</remarks>
        [MethodImpl(Inline)]
        public static T jsb<T>(N8 f, N1 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Jsb8x8x1);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Jsb16x8x1);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Jsb32x8x1);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Jsb64x8x1);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [11000011]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>JSB := msb | lsb (8x2)</remarks>
        [MethodImpl(Inline)]
        public static T jsb<T>(N8 f, N2 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Jsb8x8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Jsb16x8x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Jsb32x8x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Jsb64x8x2);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [11100111]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>JSB := msb | lsb (8x3)</remarks>
        [MethodImpl(Inline)]
        public static T jsb<T>(N8 f, N3 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Jsb8x8x3);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Jsb16x8x3);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Jsb32x8x3);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Jsb64x8x3);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [00011000]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(N8 f, N2 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Central8x8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Central16x8x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Central32x8x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Central64x8x2);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [00111100]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(N8 f, N4 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Central8x8x4);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Central16x8x4);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Central32x8x4);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Central64x8x4);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [01111110]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(N8 f, N6 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Central8x8x6);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Central16x8x6);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Central32x8x6);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Central64x8x6);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [10011001]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="cd">The central bit density</param>
        /// <param name="jsbd">The jsb bit density</param>
        /// <param name="t">The mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>CJSB := jsb | csb (8x2x1)</remarks>
        [MethodImpl(Inline)]
        public static T cjsb<T>(N8 f, N2 cd, N1 jsbd, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(CJsb8x8x2x1);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(CJsb16x8x2x1);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(CJsb32x8x2x1);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(CJsb64x8x2x1);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [11011011]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="cd">The central bit density</param>
        /// <param name="jsbd">The jsb bit density</param>
        /// <param name="t">The mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>CJSB := jsb | csb (8x2x2)</remarks>
        [MethodImpl(Inline)]
        public static T cjsb<T>(N8 f, N2 cd, N2 jsbd, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(CJsb8x8x2x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(CJsb16x8x2x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(CJsb32x8x2x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(CJsb64x8x2x2);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [10111101]
        /// </summary>
        /// <param name="f">The frequency selector</param>
        /// <param name="cd">The central bit density</param>
        /// <param name="t">The mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>CJSB := jsb | csb (8x4x1)</remarks>
        [MethodImpl(Inline)]
        public static T cjsb<T>(N8 f, N4 cd, N1 jsbd, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(CJsb8x8x4x1);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(CJsb16x8x4x1);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(CJsb32x8x4x1);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(CJsb64x8x4x1);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static byte lsb8f(byte density)
            => (byte)(byte.MaxValue >> (8 - density));

        [MethodImpl(Inline)]
        public static byte msb8f(byte density)
            => (byte)(byte.MaxValue << (8 - density));

        
        [MethodImpl(Inline)]
        static ulong lsb<W>(W w, N2 f, N1 d)
            where W : unmanaged, ITypeNat
        {
            if(typeof(W) == typeof(N4))
                return BitMasks.Lsb4x2;
            else if(typeof(W) == typeof(N6))
                return BitMasks.Lsb6x2;
            else if(typeof(W) == typeof(N8))
                return BitMasks.Lsb8x2;
            else if(typeof(W) == typeof(N10))
                return BitMasks.Lsb10x2;
            else if(typeof(W) == typeof(N12))
                return BitMasks.Lsb12x2;
            else if(typeof(W) == typeof(N14))
                return BitMasks.Lsb14x2;
            else if(typeof(W) == typeof(N16))
                return BitMasks.Lsb16x2;
            else if(typeof(W) == typeof(N18))
                return BitMasks.Lsb18x2;
            else if(typeof(W) == typeof(N32))
                return BitMasks.Lsb32x2;
            else if(typeof(W) == typeof(N64))
                return BitMasks.Lsb64x2;
            else 
                throw unsupported<W>();                
        }

        [MethodImpl(Inline)]
        static ulong lsb_1<W>(W w, N3 f, N1 d)
            where W : unmanaged, ITypeNat
        {
            if(typeof(W) == typeof(N6))
                return BitMasks.Lsb6x3;
            else if(typeof(W) == typeof(N9))
                return BitMasks.Lsb9x3;
            else if(typeof(W) == typeof(N12))
                return BitMasks.Lsb12x3;
            else if(typeof(W) == typeof(N15))
                return BitMasks.Lsb15x3;
            else if(typeof(W) == typeof(N18))
                return BitMasks.Lsb18x3;
            else if(typeof(W) == typeof(N21))
                return BitMasks.Lsb21x3;
            else if(typeof(W) == typeof(N24))
                return BitMasks.Lsb24x3;
            else if(typeof(W) == typeof(N27))
                return BitMasks.Lsb27x3;
            else if(typeof(W) == typeof(N30))
                return BitMasks.Lsb30x3;
            else 
                return lsb_2(w,f,d);
        }

        [MethodImpl(Inline)]
        static ulong lsb_2<W>(W w, N3 f, N1 d)
            where W : unmanaged, ITypeNat
        {
            if(typeof(W) == typeof(N33))
                return BitMasks.Lsb33x3;
            else if(typeof(W) == typeof(N36))
                return BitMasks.Lsb36x3;
            else if(typeof(W) == typeof(N39))
                return BitMasks.Lsb39x3;
            else if(typeof(W) == typeof(N41))
                return BitMasks.Lsb41x3;
            else if(typeof(W) == typeof(N44))
                return BitMasks.Lsb44x3;
            else if(typeof(W) == typeof(N48))
                return BitMasks.Lsb48x3;
            else if(typeof(W) == typeof(N51))
                return BitMasks.Lsb51x3;
            else 
                throw unsupported<W>();                
        }

        [MethodImpl(Inline)]
        static ulong msb<W>(W w, N2 f, N1 d)
            where W : unmanaged, ITypeNat
        {
            if(typeof(W) == typeof(N4))
                return BitMasks.Msb4x2;
            else if(typeof(W) == typeof(N6))
                return BitMasks.Msb6x2;
            else if(typeof(W) == typeof(N8))
                return BitMasks.Msb8x2;
            else if(typeof(W) == typeof(N10))
                return BitMasks.Msb10x2;
            else if(typeof(W) == typeof(N12))
                return BitMasks.Msb12x2;
            else if(typeof(W) == typeof(N14))
                return BitMasks.Msb14x2;
            else if(typeof(W) == typeof(N16))
                return BitMasks.Msb16x2;
            else if(typeof(W) == typeof(N18))
                return BitMasks.Msb18x2;
            else if(typeof(W) == typeof(N32))
                return BitMasks.Msb32x2;
            else if(typeof(W) == typeof(N64))
                return BitMasks.Msb64x2;
            else 
                throw unsupported<W>();                
        }

    }   
}