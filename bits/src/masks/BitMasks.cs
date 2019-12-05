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

    public static partial class BitMasks
    {        
        /// <summary>
        /// [00000001 ... 00000001]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb8x1<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Lsb64x8x1));

        /// <summary>
        /// [00000011 ... 00000011]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb8x2<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Lsb64x8x2));

        /// <summary>
        /// [00000111 ... 00000111]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb8x3<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Lsb64x8x3));

        /// <summary>
        /// [00001111 ... 00001111]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb8x4<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Lsb64x8x4));

        /// <summary>
        /// [00011111 ... 00011111]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb8x5<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Lsb64x8x5));

        /// <summary>
        /// [00111111 ... 00111111]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb8x6<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Lsb64x8x6));

        /// <summary>
        /// [01111111 ... 01111111]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb8x7<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Lsb64x8x7));

        /// <summary>
        /// [00000000 00000000 00000000 0000001 00000000 00000000 00000000 0000001]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T lsb32x1<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Lsb64x32x1));

        /// <summary>
        /// [10000000 ... 10000000]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T msb8x1<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Msb64x8x2));

        /// <summary>
        /// [11000000 ... 11000000]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T msb8x2<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Msb64x8x2));

        /// <summary>
        /// [11100000 ... 11100000]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T msb8x3<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Msb64x8x3));

        /// <summary>
        /// [11110000 ... 11110000]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T msb8x4<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Msb64x8x4));

        /// <summary>
        /// [11111000 ... 11111000]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T msb8x5<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Msb64x8x5));

        /// <summary>
        /// [11111100 ... 11111100]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T msb8x6<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Msb64x8x6));

        /// <summary>
        /// [11111110 ... 11111110]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T msb8x7<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Msb64x8x7));
 
        /// <summary>
        /// [10000000 00000000 00000000 000000 10000000 00000000 00000000 0000000]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T msb32x1<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), Msb64x32x1));

    }

}