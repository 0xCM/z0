//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

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
        public static Vec128<ushort> vxorsr(in Vec128<ushort> src, byte offset)
            => dinx.vxor(in src, vsrl(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vxorsr(in Vec128<uint> src, byte offset)
            => dinx.vxor(in src,vsrl(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vxorsr(in Vec128<ulong> src, byte offset)
            => dinx.vxor(in src, vsrl(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vxorsr(in Vec256<ushort> src, byte offset)
            => dinx.vxor(in src, vsrl(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vxorsr(in Vec256<uint> src, byte offset)
            => dinx.vxor(in src, vsrl(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vxorsr(in Vec256<ulong> src, byte offset)
            => dinx.vxor(in src, vsrl(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vxorsrv(in Vec128<uint> src, in Vec128<uint> offsets)
            => dinx.vxor(in src, dinx.vsrlv(in src,in offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vxorsrv(in Vec128<ulong> src, in Vec128<ulong> offsets)
            => dinx.vxor(in src, dinx.vsrlv(in src, in offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vxorsrv(in Vec256<uint> src, in Vec256<uint> offsets)
            => dinx.vxor(in src, dinx.vsrlv(in src, in offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vxorsrv(in Vec256<ulong> src, in Vec256<ulong> offsets)
            => dinx.vxor(in src, dinx.vsrlv(in src, in offsets));
    }

}