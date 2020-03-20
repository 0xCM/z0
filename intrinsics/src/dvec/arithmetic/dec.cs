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

    using static Root;    
    using static Nats;

    partial class dvec    
    {
        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<sbyte> vdec(Vector128<sbyte> src)
            =>  vsub(src, Data.vunits<sbyte>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<byte> vdec(Vector128<byte> src)
            =>  vsub(src, Data.vunits<byte>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<short> vdec(Vector128<short> src)
            =>  vsub(src, Data.vunits<short>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<ushort> vdec(Vector128<ushort> src)
            =>  vsub(src, Data.vunits<ushort>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<int> vdec(Vector128<int> src)
            =>  vsub(src, Data.vunits<int>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<uint> vdec(Vector128<uint> src)
            =>  vsub(src, Data.vunits<uint>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<long> vdec(Vector128<long> src)
            =>  vsub(src, Data.vunits<long>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector128<ulong> vdec(Vector128<ulong> src)
            =>  vsub(src, Data.vunits<ulong>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<sbyte> vdec(Vector256<sbyte> src)
            =>  vsub(src, Data.vunits<sbyte>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<byte> vdec(Vector256<byte> src)
            =>  vsub(src, Data.vunits<byte>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<short> vdec(Vector256<short> src)
            =>  vsub(src, Data.vunits<short>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<ushort> vdec(Vector256<ushort> src)
            =>  vsub(src, Data.vunits<ushort>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<int> vdec(Vector256<int> src)
            =>  vsub(src, Data.vunits<int>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<uint> vdec(Vector256<uint> src)
            =>  vsub(src, Data.vunits<uint>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<long> vdec(Vector256<long> src)
            =>  vsub(src, Data.vunits<long>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Dec]
        public static Vector256<ulong> vdec(Vector256<ulong> src)
            =>  vsub(src, Data.vunits<ulong>(n256));
    }
}