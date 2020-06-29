//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    using static Memories;

    using API = BitFields;

    /// <summary>
    /// Defines a stateful numeric bitfield api surface parametrized by an indexing enum and numeric type
    /// </summary>
    /// <typeparam name="E">A indexing enumeration</typeparam>
    /// <typeparam name="T">The numeric type over which the bitfield is defined</typeparam>
    public readonly ref struct BitField<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        /// <summary>
        /// The bitfield definition upon which the reader is predicated
        /// </summary>
        public readonly BitFieldSpec Spec;

        readonly ReadOnlySpan<BitFieldSegment> Segs;

        [MethodImpl(Inline)]
        internal BitField(in BitFieldSpec spec)
        {
            this.Spec = spec;
            this.Segs = spec.Segments;            
        }

        /// <summary>
        /// Fetches an index-identified segment
        /// </summary>
        /// <param name="index">The segment index</param>
        [MethodImpl(Inline)]
        public ref readonly BitFieldSegment Segment(E index)
            => ref skip(Segs, Enums.scalar<E,byte>(index));

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the spegment specification
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The value from which the segment will be extracted</param>
        [MethodImpl(Inline)]
        public T Extract(in BitFieldSegment segment, in T src)
            => API.extract(segment, src);

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the spegment specification
        /// </summary>
        /// <param name="index">The segment index</param>
        /// <param name="src">The value from which the segment will be extracted</param>
        [MethodImpl(Inline)]
        public T Extract(E index, in T src)
            => API.extract(Segment(index), src);

        /// <summary>
        /// Extracts all segments from the source value and deposits the result in a caller-suppled span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public void Deposit(in T src, Span<T> dst)
            => API.deposit(Spec, src, dst);

        /// <summary>
        /// Extracts a source segment to the least bits of the target then shifts the target by a specified offset
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline)]
        public T Extract(in BitFieldSegment segment, in T src, bool offset)
            => API.extract(segment, src, offset);

        /// <summary>
        /// Extracts a source segment to the least bits of the target then shifts the target by a specified offset
        /// </summary>
        /// <param name="index">The segment index</param>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline)]
        public T Extract(E index, in T src, bool offset)
            => API.extract(Segment(index), src, offset);

        /// <summary>
        /// Overwrites an identified target segment with the bits from the corresponding source segment
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline)]
        public ref T Deposit(in BitFieldSegment segment, in T src, ref T dst)
        {
            API.deposit(segment, src, ref dst);
            return ref dst;
        }            

        /// <summary>
        /// Overwrites an identified target segment with the bits from the corresponding source segment
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline)]
        public ref T Deposit(E index, in T src, ref T dst)
        {
            API.deposit(Segment(index), src, ref dst);
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public ref T Deposit(ReadOnlySpan<T> src, ref T dst)
        {   
            API.deposit(Spec, src, ref dst);
            return ref dst;
        }                 
    }
}