//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector4 bzhi(BitVector4 src, int pos)
            => gbits.zerohi(src.data, (byte)pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector8 bzhi(BitVector8 src, int pos)
            => gbits.zerohi(src.data, (byte)pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector16 bzhi(BitVector16 src, int pos)
            => gbits.zerohi(src.data, (byte)pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector32 bzhi(BitVector32 src, int pos)
            => gbits.zerohi(src.data, (byte)pos);

        /// <summary>
        /// Disables the high bits starting at a specified position
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector64 bzhi(BitVector64 src, int pos)
            => gbits.zerohi(src.data, (byte)pos);

    }

}