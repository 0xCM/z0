//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class BitBlocks
    {
        /// <summary>
        /// Loads a bitblock from a 4-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N4,byte> init(BitVector4 src)
            => new BitBlock<N4,byte>(src);

        /// <summary>
        /// Loads a bitblock from an 8-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N8,byte> init(BitVector8 src)
            => new BitBlock<N8,byte>(src);

        /// <summary>
        /// Loads a bitblock from a 16-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N16,ushort> init(BitVector16 src)
            => new BitBlock<N16,ushort>(src);

        /// <summary>
        /// Loads a bitblock from a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N32,uint> init(BitVector32 src)
            => new BitBlock<N32,uint>(src);

        /// <summary>
        /// Loads a bitblock from a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N64,ulong> init(BitVector64 src)
            => new BitBlock<N64,ulong>(src);

        /// <summary>
        /// Loads a bitblock from a generic bitvector
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitBlock<T> init<T>(BitVector<T> src)
            where T : unmanaged
                => new BitBlock<T>((T)src, bitsize<T>());

        /// <summary>
        /// Loads a bitblock from a bitstring
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitBlock<T> init<T>(BitString src)
            where T : unmanaged
                => load<T>(src.ToPackedBytes(), (uint)src.Length);
    }
}