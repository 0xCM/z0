//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    using static BitMasks;

    public static partial class BitMask
    {            
        /// <summary>
        /// [00000000 00000000 00000000 00000001]    
        /// Selects a mask where the least significant bit is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(N1 f = default, N1 d = default)
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
        /// [01 01 01 01 01 01 01 01 01 01 01 01 01 01 01 01]    
        /// Selects a mask where the least significant bit out of every two bits is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(N2 f, N1 d = default)
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
        /// [0001 0001 0001 0001 0001 0001 0001 0001]
        /// Selects a mask where the least significant bit out of every four bits is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(N4 f, N1 d = default)
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
        /// [00000001 00000001 00000001 00000001]
        /// Selects a mask where the least significant bit out of every eight bits is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(N8 f, N1 d = default)
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
        /// [00000000 00000001 00000000 00000001]
        /// Selects a mask where the least significant bit out of every 16 bits is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(N16 f, N1 d = default)
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
        /// [00000011 00000011 00000011 00000011]
        /// Creates a mask where the least significant 2 bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(N8 f, N2 d)
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
        /// [00000111 00000111 00000111 00000111]
        /// Creates a mask where the least significant 3 bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(N8 f, N3 d)
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
        /// [00001111 00001111 00001111 00001111]
        /// Creates a mask where the least significant 4 bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(N8 f, N4 d)
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
        /// [00011111 00011111 00011111 00011111]
        /// Creates a mask where the least significant 5 bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(N8 f, N5 d)
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
        /// [00111111 00111111 00111111 00111111]
        /// Creates a mask where the least significant 6 bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(N8 f, N6 d)
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
        /// [00111111 00111111 00111111 00111111]
        /// Creates a mask where the least significant 7 bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb<T>(N8 f, N7 d)
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
        /// [10000000 00000000 00000000 00000000]    
        /// Selects a mask where the most significant bit is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(N1 f = default, N1 d = default)
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
        /// [10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10]
        /// Selects a mask where the most significant bit out of every two bits is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(N2 f, N1 d = default)
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
        /// [10001000 10001000 10001000 10001000]
        /// Selects a mask where the most significant bit out of every four bits is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(N4 f, N1 d = default)
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
        /// [10000000 10000000 10000000 10000000]
        /// Selects a mask where the most significant bit out of every eight bits is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N1 d = default)
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
        /// [10000000 00000000 10000000 00000000]
        /// Selects a mask where the most significant bit out of every eight bits is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(N16 f, N1 d = default)
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
        /// [11000000 11000000 11000000 11000000]
        /// Creates a mask where the 2 most significant bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N2 d)
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
        /// [11100000 11100000 11100000 11100000]
        /// Creates a mask where the 3 most significant bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N3 d)
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
        /// [11110000 11110000 11110000 11110000]
        /// Creates a mask where the 4 most significant bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N4 d)
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
        /// [11111000 11111000 11111000 11111000]
        /// Creates a mask where the 5 most significant bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N5 d)
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
        /// [11111100 11111100 11111100 11111100]
        /// Creates a mask where the 6 most significant bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N6 d)
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
        /// [11111110 11111110 11111110 11111110]
        /// Creates a mask where the 7 most significant bits of every 8-bit segment are enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T msb<T>(N8 f, N7 d)
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

        [MethodImpl(Inline)]
        public static byte lsb8f(byte density)
            => (byte)(byte.MaxValue >> (8 - density));

        [MethodImpl(Inline)]
        public static byte msb8f(byte density)
            => (byte)(byte.MaxValue << (8 - density));

    }   
}