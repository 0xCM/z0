//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    partial class BitVector
    {

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector4 Disable(BitVector4 x, int pos)
            => new BitVector4(x.data &= (byte)~((byte)(1 << pos)),true);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector8 disable(BitVector8 x, int index)
            => BitMask.disable(x, index);

        /// <summary>
        /// Disables the bits after a specified poistion
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector8 zerohi(BitVector8 x, int index)
            => Bits.zerohi(x, (byte)++index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector16 disable(BitVector16 x, int index)
            => BitMask.disable(x, index);

        /// <summary>
        /// Disables the bits after a specified poistion
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector16 zerohi(BitVector16 x, int index)
            => Bits.zerohi(x, (byte)++index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector32 disable(BitVector32 x, int index)
            => BitMask.disable(x, index);

        /// <summary>
        /// Disables the bits after a specified poistion
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector32 zerohi(BitVector32 x, int index)
            => Bits.zerohi(x, (byte)++index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector64 disable(BitVector64 x, int index)
            => BitMask.disable(x, index);

        /// <summary>
        /// Disables the bits after a specified poistion
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector64 zerohi(BitVector64 x, int index)
            => Bits.zerohi(x, (byte)++index);
    }
}