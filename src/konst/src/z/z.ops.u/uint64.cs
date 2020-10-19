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
        /// Converts a parametric source to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong uint64<T>(T src)
            => As<T,ulong>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong uint64<T>(ref T src)
            => ref As<T,ulong>(ref src);

        /// <summary>
        /// Converts a nullable parametric source to a nullable <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong? uint64<T>(T? src)
            where T : unmanaged
                => As<T?, ulong?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ulong> uint64<T>(Span<T> src)
            where T : struct
                => recover<T,ulong>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ulong> uint64<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,ulong>(src);

        /// <summary>
        /// Converts a <see cref='sbyte'/> to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ulong uint64(sbyte src)
            => (ulong)src;

        /// <summary>
        /// Converts a <see cref='byte'/> to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ulong uint64(byte src)
            => (ulong)src;

        /// <summary>
        /// Converts a <see cref='short'/> to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ulong uint64(short src)
            => (ulong)src;

        /// <summary>
        /// Converts a <see cref='ushort'/> to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ulong uint64(ushort src)
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(int src)
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(uint src)
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(long src)
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(ulong src)
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(float src)
            => (ulong)((long)src);

        [MethodImpl(Inline), Op]
        public static ulong uint64(double src)
            => (ulong)((long)src);
    }
}