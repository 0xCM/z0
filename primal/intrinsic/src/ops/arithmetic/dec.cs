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
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vdec(in Vec128<sbyte> src)
            =>  vsub(src, ginx.vpUnits<sbyte>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vdec(in Vec128<byte> src)
            =>  vsub(src, ginx.vpUnits<byte>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vdec(in Vec128<short> src)
            =>  vsub(src, ginx.vpUnits<short>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vdec(in Vec128<ushort> src)
            =>  vsub(src, ginx.vpUnits<ushort>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vdec(in Vec128<int> src)
            =>  vsub(src, ginx.vpUnits<int>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vdec(in Vec128<uint> src)
            =>  vsub(src, ginx.vpUnits<uint>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vdec(in Vec128<long> src)
            =>  vsub(src, ginx.vpUnits<long>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vdec(in Vec128<ulong> src)
            =>  vsub(src, ginx.vpUnits<ulong>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vdec(in Vec256<sbyte> src)
            =>  vsub(src, ginx.vpUnits<sbyte>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vdec(in Vec256<byte> src)
            =>  vsub(src, ginx.vpUnits<byte>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vdec(in Vec256<short> src)
            =>  vsub(src, ginx.vpUnits<short>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vdec(in Vec256<ushort> src)
            =>  vsub(src, ginx.vpUnits<ushort>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vdec(in Vec256<int> src)
            =>  vsub(src, ginx.vpUnits<int>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vdec(in Vec256<uint> src)
            =>  vsub(src, ginx.vpUnits<uint>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vdec(in Vec256<long> src)
            =>  vsub(src, ginx.vpUnits<long>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vdec(in Vec256<ulong> src)
            =>  vsub(src, ginx.vpUnits<ulong>(n256));


    }
}