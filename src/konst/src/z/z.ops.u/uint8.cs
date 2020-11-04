//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Converts a parametric source to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte uint8<T>(T src)
            => As<T,byte>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte uint8<T>(ref T src)
            => ref As<T,byte>(ref src);

        /// <summary>
        /// Converts a nullable parametric source to a nullable <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte? uint8<T>(T? src)
            where T : struct
                => As<T?, byte?>(ref src);

        /// <summary>
        /// Converts a <see cref='sbyte'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte uint8(sbyte src)
            => (byte)src;

        /// <summary>
        /// Defines an identity function over <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte uint8(byte src)
            => (byte)src;

        /// <summary>
        /// Converts a <see cref='short'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte uint8(short src)
            => (byte)src;

        /// <summary>
        /// Converts a <see cref='ushort'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte uint8(ushort src)
            => (byte)src;

        /// <summary>
        /// Converts a <see cref='int'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte uint8(int src)
            => (byte)src;

        /// <summary>
        /// Converts a <see cref='uint'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte uint8(uint src)
            => (byte)src;

        /// <summary>
        /// Converts a <see cref='long'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte uint8(long src)
            => (byte)src;

        /// <summary>
        /// Converts a <see cref='ulong'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint uint8(ulong src)
            => (uint)src;

        /// <summary>
        /// Converts a <see cref='float'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte uint8(float src)
            => (byte)(sbyte)src;

        /// <summary>
        /// Converts a <see cref='double'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte uint8(double src)
            => (byte)(sbyte)src;
    }
}