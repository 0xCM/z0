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
        /// Determines whether an index-identified bit is enabled
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public static bit enabled<T>(BitVector<T> x, int index)
            where T : unmanaged
                => gbits.test(x.data, index);

        /// <summary>
        /// Determines whether an index-identified bit is enabled
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public static bit enabled<N,T>(BitVector<N,T> x, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.test(x.data, index);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static bit enabled(BitVector4 x, int pos)
            => BitMask.test(x.data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static bit enabled(BitVector8 x, int pos)
            => BitMask.test(x.data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static bit enabled(BitVector16 x, int pos)
            => BitMask.test(x.data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static bit enabled(BitVector32 x, int pos)
            => BitMask.test(x.data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public static bit enabled(BitVector64 x, int pos)
            => BitMask.test(x.data, pos);
    }
}