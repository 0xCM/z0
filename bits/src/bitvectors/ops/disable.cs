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
        public static BitVector4 disable(BitVector4 x, int index)
            => BitMask.disable(x, index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector8 disable(BitVector8 x, int index)
            => BitMask.disable(x, index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector16 disable(BitVector16 x, int index)
            => BitMask.disable(x, index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector32 disable(BitVector32 x, int index)
            => BitMask.disable(x, index);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="index">The bit position</param>
        [MethodImpl(Inline)]
        public static BitVector64 disable(BitVector64 x, int index)
            => BitMask.disable(x, index);

    }
}