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

    using static Typed;
    using static V0p;
    using static Konst;
    
    partial struct V0d
    {
        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<sbyte> vdec(Vector128<sbyte> src)
            => vsub(src, vunits<sbyte>(w128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<byte> vdec(Vector128<byte> src)
            => vsub(src, vunits<byte>(w128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<short> vdec(Vector128<short> src)
            => vsub(src, vunits<short>(w128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<ushort> vdec(Vector128<ushort> src)
            => vsub(src, vunits<ushort>(w128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<int> vdec(Vector128<int> src)
            => vsub(src, vunits<int>(w128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<uint> vdec(Vector128<uint> src)
            => vsub(src, vunits<uint>(w128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<long> vdec(Vector128<long> src)
            => vsub(src, vunits<long>(w128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<ulong> vdec(Vector128<ulong> src)
            => vsub(src, vunits<ulong>(w128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<sbyte> vdec(Vector256<sbyte> src)
            => vsub(src, vunits<sbyte>(w256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<byte> vdec(Vector256<byte> src)
            => vsub(src, vunits<byte>(w256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<short> vdec(Vector256<short> src)
            => vsub(src, vunits<short>(w256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<ushort> vdec(Vector256<ushort> src)
            => vsub(src, vunits<ushort>(w256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<int> vdec(Vector256<int> src)
            => vsub(src, vunits<int>(w256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<uint> vdec(Vector256<uint> src)
            => vsub(src, vunits<uint>(w256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<long> vdec(Vector256<long> src)
            => vsub(src, vunits<long>(w256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<ulong> vdec(Vector256<ulong> src)
            => vsub(src, vunits<ulong>(w256));
    }
}