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
    /// Defines the (stateful) bitfield api surface parametrized by an indexing enum
    /// </summary>
    /// <typeparam name="T">The type over which the bitfield is defined</typeparam>
    /// <typeparam name="E">A indexing enumeration</typeparam>
    public readonly ref struct BitField<S,E,T>
        where S : IScalarBitField<T>
        where E : unmanaged
        where T : unmanaged
    {
        /// <summary>
        /// The bitfield definition upon which the reader is predicated
        /// </summary>
        public readonly BitFieldSpec Spec;

        readonly ReadOnlySpan<BitSegment> Segments;

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
        public ref readonly BitSegment Segment(E index)
            => ref skip(Segments, @as<E,uint>(index));

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the segment specification
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The value from which the segment will be extracted</param>
        [MethodImpl(Inline)]
        public T Read(in BitSegment segment, in S src)
            => api.extract<S,T>(segment, src);

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the segment specification
        /// </summary>
        /// <param name="index">The segment index</param>
        /// <param name="src">The value from which the segment will be extracted</param>
        [MethodImpl(Inline)]
        public T Read(E index, in S src)
            => api.extract<S,T>(Segment(index), src);

        /// <summary>
        /// Extracts all segments from the source value and deposits the result in a caller-suppled span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public void Read(in S src, Span<T> dst)
            => api.deposit(Spec, src, dst);

        /// <summary>
        /// Extracts a source segment to the least bits of the target then shifts the target by a specified offset
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline)]
        public T Read(in BitSegment segment, in S src, bool offset)
            => api.extract<S,T>(segment, src, offset);

        /// <summary>
        /// Extracts a source segment to the least bits of the target then shifts the target by a specified offset
        /// </summary>
        /// <param name="index">The segment index</param>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline)]
        public T Read(E index, in S src, bool offset)
            => api.extract<S,T>(Segment(index), src, offset);

        /// <summary>
        /// Overwrites an identified target segment with the bits from the corresponding source segment
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline)]
        public ref T Write(in BitSegment segment, in S src, ref T dst)
        {
            api.deposit(segment, src, ref dst);
            return ref dst;
        }

        /// <summary>
        /// Overwrites an identified target segment with the bits from the corresponding source segment
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline)]
        public ref S Write(in BitSegment segment, in S src, ref S dst)
        {
            api.deposit<S,T>(segment, src, ref dst);
            return ref dst;
        }

        /// <summary>
        /// Overwrites an identified target segment with the bits from the corresponding source segment
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline)]
        public ref S Write(E index, in S src, ref S dst)
        {
            api.deposit<S,T>(Segment(index), src, ref dst);
            return ref dst;
        }

        /// <summary>
        /// Overwrites an index-identified target segment with the bits from the corresponding source segment
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline)]
        public ref T Write(E index, in S src, ref T dst)
        {
            api.deposit<S,T>(Segment(index), src, ref dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref S Write(ReadOnlySpan<T> src, ref S dst)
        {
            var data = dst.Scalar;
            dst.Update(api.deposit<S,T>(Spec, src, ref data));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref T Write(ReadOnlySpan<T> src, ref T dst)
        {
            api.deposit<S,T>(Spec, src, ref dst);
            return ref dst;
        }
    }
}