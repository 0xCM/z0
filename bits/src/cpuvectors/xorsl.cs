//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static zfunc;    

    partial class Bits
    {
        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vxorsl(in Vec128<ushort> src, byte offset)
            => vxor(in src,sll(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vxorsl(in Vec128<uint> src, byte offset)
            => vxor(in src,sll(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vxorsl(in Vec128<ulong> src, byte offset)
            => vxor(in src,sll(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vxorsl(in Vec256<ushort> src, byte offset)
            => vxor(in src,sll(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vxorsl(in Vec256<uint> src, byte offset)
            => vxor(in src,sll(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vxorsl(in Vec256<ulong> src, byte offset)
            => vxor(in src,sll(in src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vxorslv(in Vec128<uint> src, in Vec128<uint> offsets)
            => vxor(in src,vsllv(in src,in offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> xorslv(in Vec128<ulong> src, in Vec128<ulong> offsets)
            => vxor(in src,vsllv(in src,in offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vxorslv(in Vec256<uint> src, in Vec256<uint> offsets)
            => vxor(in src,vsllv(in src,in offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vxorslv(in Vec256<ulong> src, in Vec256<ulong> offsets)
            => vxor(in src,vsllv(in src,in offsets));

    }

}