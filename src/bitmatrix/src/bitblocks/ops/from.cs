//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class BitBlocks
    {
        /// <summary>
        /// Loads a bitblock from a 4-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N4,byte> from(BitVector4 src)
            => new BitBlock<N4,byte>(src);

        /// <summary>
        /// Loads a bitblock from an 8-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N8,byte> from(BitVector8 src)
            => new BitBlock<N8,byte>(src);

        /// <summary>
        /// Loads a bitblock from a 16-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N16,ushort> from(BitVector16 src)
            => new BitBlock<N16,ushort>(src);

        /// <summary>
        /// Loads a bitblock from a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N32,uint> from(BitVector32 src)
            => new BitBlock<N32,uint>(src);

        /// <summary>
        /// Loads a bitblock from a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N64,ulong> from(BitVector64 src)
            => new BitBlock<N64,ulong>(src);

        /// <summary>
        /// Loads a bitblock from a generic bitvector
        /// </summary>
        /// <param name="src">The source bitvector</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitBlock<T> from <T>(BitVector<T> src)
            where T : unmanaged
                => new BitBlock<T>((T)src, bitsize<T>());

        /// <summary>
        /// Loads a bitblock from a bitstring
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitBlock<T> from<T>(BitString src)
            where T : unmanaged
                => load<T>(src.ToPackedBytes(), (uint)src.Length);

        /// <summary>
        /// Creates a bitvector from a span of bytes
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The bitvector length</param>
        static BitBlock<T> load<T>(Span<byte> src, uint n)
            where T : unmanaged
        {
            var q = Math.DivRem(src.Length, (int)z.size<T>(), out int r);
            var cellcount = r == 0 ? q : q + 1;
            var capacity = (int)z.size<T>();
            var cells = new T[cellcount];
            for(int i=0, offset = 0; i<cellcount; i++, offset += capacity)
                cells[i] = src.Slice(offset).Take<T>();
            return new BitBlock<T>(cells, n);
        }
    }
}