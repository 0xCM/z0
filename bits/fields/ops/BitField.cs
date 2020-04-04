//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    

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

        readonly ReadOnlySpan<FieldSegment> Segments;

        [MethodImpl(Inline)]
        internal BitField(in BitFieldSpec spec)
        {
            this.Spec = spec;
            this.Segments = spec.Segments;            
        }

        BitFieldOps<T> Ops
        {
            [MethodImpl(Inline)]
            get => default;
        }

        /// <summary>
        /// Fetches an index-identified segment
        /// </summary>
        /// <param name="index">The segment index</param>
        [MethodImpl(Inline)]
        public ref readonly FieldSegment Segment(byte index)
            => ref skip(Segments, index);

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the spegment specification
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="bf">The value from which the segment will be extracted</param>
        [MethodImpl(Inline)]
        public T Read(in FieldSegment segment, T bf)
            => Ops.Read(segment, bf);

        /// <summary>
        /// Extracts all segments from the source value and deposits the result in a caller-suppled span
        /// </summary>
        /// <param name="bf">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public void Read(T bf, Span<T> dst)
            => Ops.Read(Spec, bf, dst);

        /// <summary>
        /// Extracts a source segment to the least bits of the target then shifts the target by a specified offset
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="bf">The source value</param>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline)]
        public T Read(in FieldSegment segment, T bf, bool offset)
            => Ops.Read(segment, bf, offset);

        [MethodImpl(Inline)]
        public ref T Write(in FieldSegment segment, T bf, ref T dst)
        {
            Ops.Write(segment, bf, ref dst);
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public ref T Write(ReadOnlySpan<T> src, ref T dst)
        {   
            Ops.Write(Spec, src, ref dst);
            return ref dst;
        }        
    }
}