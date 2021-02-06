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

    using api = BitFields;

    /// <summary>
    /// Defines the (stateful) bitfield api surface
    /// </summary>
    /// <typeparam name="T">The type over which the bitfield is defined</typeparam>
    public readonly ref struct BitField<T>
        where T : unmanaged
    {
        /// <summary>
        /// The bitfield definition upon which the reader is predicated
        /// </summary>
        public readonly BitFieldSpec Spec;

        readonly ReadOnlySpan<BitFieldSegment> Segments;

        [MethodImpl(Inline)]
        public BitField(in BitFieldSpec spec)
        {
            Spec = spec;
            Segments = spec.Segments;
        }

        /// <summary>
        /// Fetches an index-identified segment
        /// </summary>
        /// <param name="index">The segment index</param>
        [MethodImpl(Inline)]
        public ref readonly BitFieldSegment Segment(int index)
            => ref skip(Segments, index);

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the segment specification
        /// </summary>
        /// <param name="seg">The segment spec</param>
        /// <param name="src">The value from which the segment will be extracted</param>
        [MethodImpl(Inline)]
        public T Extract(in BitFieldSegment seg, T src)
            => api.extract(seg, src);

        /// <summary>
        /// Extracts all segments from the source value and deposits the result in a caller-suppled span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public void Deposit(T src, Span<T> dst)
            => api.deposit(Spec, src, dst);

        /// <summary>
        /// Extracts a source segment to the least bits of the target then shifts the target by a specified offset
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline)]
        public T Extract(in BitFieldSegment segment, T src, bool offset)
            => api.extract(segment, src, offset);

        [MethodImpl(Inline)]
        public ref T Deposit(in BitFieldSegment segment, T src, ref T dst)
        {
            api.deposit(segment, src, ref dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref T Deposit(ReadOnlySpan<T> src, ref T dst)
        {
            api.deposit(Spec, src, ref dst);
            return ref dst;
        }
    }
}