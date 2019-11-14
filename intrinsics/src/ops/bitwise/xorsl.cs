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
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vxorsl(Vector128<ushort> src, byte offset)
            => dinx.vxor(src, vsll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vxorsl(Vector128<uint> src, byte offset)
            => dinx.vxor(src, vsll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vxorsl(Vector128<ulong> src, byte offset)
            => dinx.vxor(src, vsll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vxorsl(Vector256<ushort> src, byte offset)
            => dinx.vxor(src, vsll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vxorsl(Vector256<uint> src, byte offset)
            => dinx.vxor(src, vsll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vxorsl(Vector256<ulong> src, byte offset)
            => dinx.vxor(src, vsll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vxorslv(Vector128<uint> src, Vector128<uint> offsets)
            => dinx.vxor(src, dinx.vsllv(src,offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vxorslv(Vector128<ulong> src, Vector128<ulong> offsets)
            => dinx.vxor(src,dinx.vsllv(src,offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vxorslv(Vector256<uint> src, Vector256<uint> offsets)
            => dinx.vxor(src, dinx.vsllv(src,offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vxorslv(Vector256<ulong> src, Vector256<ulong> offsets)
            => dinx.vxor(src, dinx.vsllv(src,offsets));
    }
}