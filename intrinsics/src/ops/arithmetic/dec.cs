//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static zfunc;

    partial class dinx    
    {
        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vdec(Vector128<sbyte> src)
            =>  vsub(src, ginx.vpunits<sbyte>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vdec(Vector128<byte> src)
            =>  vsub(src, ginx.vpunits<byte>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vdec(Vector128<short> src)
            =>  vsub(src, ginx.vpunits<short>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vdec(Vector128<ushort> src)
            =>  vsub(src, ginx.vpunits<ushort>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vdec(Vector128<int> src)
            =>  vsub(src, ginx.vpunits<int>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vdec(Vector128<uint> src)
            =>  vsub(src, ginx.vpunits<uint>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vdec(Vector128<long> src)
            =>  vsub(src, ginx.vpunits<long>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vdec(Vector128<ulong> src)
            =>  vsub(src, ginx.vpunits<ulong>(n128));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vdec(Vector256<sbyte> src)
            =>  vsub(src, ginx.vpunits<sbyte>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vdec(Vector256<byte> src)
            =>  vsub(src, ginx.vpunits<byte>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vdec(Vector256<short> src)
            =>  vsub(src, ginx.vpunits<short>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vdec(Vector256<ushort> src)
            =>  vsub(src, ginx.vpunits<ushort>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vdec(Vector256<int> src)
            =>  vsub(src, ginx.vpunits<int>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vdec(Vector256<uint> src)
            =>  vsub(src, ginx.vpunits<uint>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vdec(Vector256<long> src)
            =>  vsub(src, ginx.vpunits<long>(n256));

        /// <summary>
        /// Decrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vdec(Vector256<ulong> src)
            =>  vsub(src, ginx.vpunits<ulong>(n256));


    }
}