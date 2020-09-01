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

    using static Konst;
    using static z;

    partial struct z
    {
        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<sbyte> vinc(Vector128<sbyte> src)
            =>  vadd(src, vunits<sbyte>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<byte> vinc(Vector128<byte> src)
            =>  vadd(src, vunits<byte>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<short> vinc(Vector128<short> src)
            =>  vadd(src, vunits<short>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<ushort> vinc(Vector128<ushort> src)
            => vadd(src, vunits<ushort>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<int> vinc(Vector128<int> src)
            => vadd(src, vunits<int>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<uint> vinc(Vector128<uint> src)
            => vadd(src, vunits<uint>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<long> vinc(Vector128<long> src)
            => vadd(src, vunits<long>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector128<ulong> vinc(Vector128<ulong> src)
            => vadd(src, vunits<ulong>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<sbyte> vinc(Vector256<sbyte> src)
            => vadd(src, vunits<sbyte>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<byte> vinc(Vector256<byte> src)
            => vadd(src, vunits<byte>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<short> vinc(Vector256<short> src)
            => vadd(src, vunits<short>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<ushort> vinc(Vector256<ushort> src)
            => vadd(src, vunits<ushort>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<int> vinc(Vector256<int> src)
            => vadd(src, vunits<int>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<uint> vinc(Vector256<uint> src)
            => vadd(src, vunits<uint>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<long> vinc(Vector256<long> src)
            => vadd(src, vunits<long>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Inc]
        public static Vector256<ulong> vinc(Vector256<ulong> src)
            => vadd(src, vunits<ulong>(n256));
    }
}