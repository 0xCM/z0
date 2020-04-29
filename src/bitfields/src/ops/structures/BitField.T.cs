//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;

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

        readonly ReadOnlySpan<FieldSegment> Segs;

        [MethodImpl(Inline)]
        internal BitField(in BitFieldSpec spec)
        {
            this.Spec = spec;
            this.Segs = spec.Segments;            
        }

        BitFieldOps<T> api { [MethodImpl(Inline)] get => default; }

        /// <summary>
        /// Fetches an index-identified segment
        /// </summary>
        /// <param name="index">The segment index</param>
        [MethodImpl(Inline)]
        public ref readonly FieldSegment Segment(int index)
            => ref skip(Segs, index);

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the spegment specification
        /// </summary>
        /// <param name="seg">The segment spec</param>
        /// <param name="src">The value from which the segment will be extracted</param>
        [MethodImpl(Inline)]
        public T Extract(in FieldSegment seg, T src)
            => api.Extract(seg, src);

        /// <summary>
        /// Extracts all segments from the source value and deposits the result in a caller-suppled span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public void Deposit(T src, Span<T> dst)
            => api.Deposit(Spec, src, dst);

        /// <summary>
        /// Extracts a source segment to the least bits of the target then shifts the target by a specified offset
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline)]
        public T Extract(in FieldSegment segment, T src, bool offset)
            => api.Extract(segment, src, offset);

        [MethodImpl(Inline)]
        public ref T Deposit(in FieldSegment segment, T src, ref T dst)
        {
            api.Deposit(segment, src, ref dst);
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public ref T Deposit(ReadOnlySpan<T> src, ref T dst)
        {   
            api.Deposit(Spec, src, ref dst);
            return ref dst;
        }        
    }
}