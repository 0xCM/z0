//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial struct z
    {
        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<sbyte> vinc(Vector128<sbyte> src)
            => cpu.vadd(src, vunits<sbyte>(n128));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<byte> vinc(Vector128<byte> src)
            => cpu.vadd(src, vunits<byte>(n128));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<short> vinc(Vector128<short> src)
            => cpu.vadd(src, vunits<short>(n128));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<ushort> vinc(Vector128<ushort> src)
            => cpu.vadd(src, vunits<ushort>(n128));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<int> vinc(Vector128<int> src)
            => cpu.vadd(src, vunits<int>(n128));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<uint> vinc(Vector128<uint> src)
            => cpu.vadd(src, vunits<uint>(n128));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<long> vinc(Vector128<long> src)
            => cpu.vadd(src, vunits<long>(n128));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<ulong> vinc(Vector128<ulong> src)
            => cpu.vadd(src, vunits<ulong>(n128));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<sbyte> vinc(Vector256<sbyte> src)
            => cpu.vadd(src, vunits<sbyte>(n256));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<byte> vinc(Vector256<byte> src)
            => cpu.vadd(src, vunits<byte>(n256));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<short> vinc(Vector256<short> src)
            => cpu.vadd(src, vunits<short>(n256));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<ushort> vinc(Vector256<ushort> src)
            => cpu.vadd(src, vunits<ushort>(n256));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<int> vinc(Vector256<int> src)
            => cpu.vadd(src, vunits<int>(n256));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<uint> vinc(Vector256<uint> src)
            => cpu.vadd(src, vunits<uint>(n256));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<long> vinc(Vector256<long> src)
            => cpu.vadd(src, vunits<long>(n256));

        /// <summary>
        /// Increments each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<ulong> vinc(Vector256<ulong> src)
            => cpu.vadd(src, vunits<ulong>(n256));
    }
}