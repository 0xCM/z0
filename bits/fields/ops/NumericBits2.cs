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
    /// Defines a stateful numeric bitfield api surface parametrized by an indexing enum and numeric type
    /// </summary>
    /// <typeparam name="I">A indexing enumeration</typeparam>
    /// <typeparam name="T">The numeric type over which the bitfield is defined</typeparam>
    public readonly ref struct NumericBits<I,T>
        where I : unmanaged, Enum
        where T : unmanaged
    {
        /// <summary>
        /// The bitfield definition upon which the reader is predicated
        /// </summary>
        public readonly BitFieldSpec Spec;

        readonly ReadOnlySpan<FieldSegment> Segments;

        [MethodImpl(Inline)]
        internal NumericBits(in BitFieldSpec spec)
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
        public ref readonly FieldSegment Segment(I index)
            => ref skip(Segments, Enums.numeric<I,byte>(index));

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the spegment specification
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The value from which the segment will be extracted</param>
        [MethodImpl(Inline)]
        public T Read(in FieldSegment segment, in T src)
            => Ops.Read(segment, src);

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the spegment specification
        /// </summary>
        /// <param name="index">The segment index</param>
        /// <param name="src">The value from which the segment will be extracted</param>
        [MethodImpl(Inline)]
        public T Read(I index, in T src)
            => Ops.Read(Segment(index), src);

        /// <summary>
        /// Extracts all segments from the source value and deposits the result in a caller-suppled span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public void Read(in T src, Span<T> dst)
            => Ops.Read(Spec, src, dst);

        /// <summary>
        /// Extracts a source segment to the least bits of the target then shifts the target by a specified offset
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline)]
        public T Read(in FieldSegment segment, in T src, bool offset)
            => Ops.Read(segment, src, offset);

        /// <summary>
        /// Extracts a source segment to the least bits of the target then shifts the target by a specified offset
        /// </summary>
        /// <param name="index">The segment index</param>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline)]
        public T Read(I index, in T src, bool offset)
            => Ops.Read(Segment(index), src, offset);

        /// <summary>
        /// Overwrites an identified target segment with the bits from the corresponding source segment
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline)]
        public ref T Write(in FieldSegment segment, in T src, ref T dst)
        {
            Ops.Write(segment, src, ref dst);
            return ref dst;
        }            

        /// <summary>
        /// Overwrites an identified target segment with the bits from the corresponding source segment
        /// </summary>
        /// <param name="segment">The segment spec</param>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline)]
        public ref T Write(I index, in T src, ref T dst)
        {
            Ops.Write(Segment(index), src, ref dst);
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