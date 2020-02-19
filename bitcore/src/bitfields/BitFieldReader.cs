//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly ref struct BitFieldReader<T>
        where T : unmanaged
    {
        readonly BitFieldSpec spec;

        readonly ReadOnlySpan<FieldSegment> Segments;

        [MethodImpl(Inline)]
        internal BitFieldReader(in BitFieldSpec spec)
        {
            this.spec = spec;
            this.Segments = spec.Segments;            
        }

        /// <summary>
        /// Extracts a contiguous range of bits from the source value per the spegment specification
        /// </summary>
        /// <param name="segment">The specifiecation of the segment to extract</param>
        /// <param name="src">The value from which the segment will be extracted</param>
        [MethodImpl(Inline)]
        public T Read(in FieldSegment segment, T src)
            => BitField.read(segment, src);

        /// <summary>
        /// Extracts all segments from the source value and deposits the result in a caller-suppled span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public void Read(T src, Span<T> dst)
            => BitField.read(spec, src, dst);

        [MethodImpl(Inline)]
        public T Read(in FieldSegment segment, T src, bool offset)
            => BitField.read(segment, src, offset);
    }
}
