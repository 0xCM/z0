//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static zfunc;    

    partial class dinx
    {
        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vxorsr(Vector128<byte> src, byte offset)
            => dinx.vxor(src, vsrl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vxorsr(Vector128<ushort> src, byte offset)
            => dinx.vxor(src, vsrl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vxorsr(Vector128<uint> src, byte offset)
            => dinx.vxor(src,vsrl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vxorsr(Vector128<ulong> src, byte offset)
            => dinx.vxor(src, vsrl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vxorsr(Vector256<byte> src, byte offset)
            => dinx.vxor(src, vsrl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vxorsr(Vector256<ushort> src, byte offset)
            => dinx.vxor(src, vsrl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vxorsr(Vector256<uint> src, byte offset)
            => dinx.vxor(src, vsrl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vxorsr(Vector256<ulong> src, byte offset)
            => dinx.vxor(src, vsrl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vxorsrv(Vector128<uint> src, Vector128<uint> offsets)
            => dinx.vxor(src, dinx.vsrlv(src,offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vxorsrv(Vector128<ulong> src, Vector128<ulong> offsets)
            => dinx.vxor(src, dinx.vsrlv(src, offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vxorsrv(Vector256<uint> src, Vector256<uint> offsets)
            => dinx.vxor(src, dinx.vsrlv(src, offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vxorsrv(Vector256<ulong> src, Vector256<ulong> offsets)
            => dinx.vxor(src, dinx.vsrlv(src, offsets));
    }
}