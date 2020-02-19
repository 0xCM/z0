//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly ref struct BitFieldReader<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        readonly ReadOnlySpan<BitFieldSegment> Segments;

        [MethodImpl(Inline)]
        internal BitFieldReader(BitFieldSpec<E,T> spec)
        {
            this.Segments = spec.Segments;            
        }

        [MethodImpl(Inline)]
        public T ReadValue(E id, T src)
        {
            ref readonly var spec = ref SegSpec(id);
            return gbits.bitslice(src, (byte)spec.StartPos, (byte)spec.Width);
        }

        [MethodImpl(Inline)]
        public T ReadValue(byte index, T src)
        {
            ref readonly var spec = ref skip(Segments, index);
            return gbits.bitslice(src, (byte)spec.StartPos, (byte)spec.Width);
        }

        [MethodImpl(Inline)]
        public T ReadValue(in BitFieldSegment segment, T src)
            => gbits.bitslice(src, (byte)segment.StartPos, (byte)segment.Width);

        [MethodImpl(Inline)]
        public ref T MergeValue(E id, ref T src)
        {
            src = gmath.or(src, gmath.sll(ReadValue(id, src), evalue<E,byte>(id)));
            return ref src;
        }

        [MethodImpl(Inline)]
        public ref T MergeValue(byte index, ref T src)
        {
            ref readonly var spec = ref skip(Segments, index);
            src = gmath.or(src, gmath.sll(ReadValue(index, src), spec.Width));
            return ref src;
        }

        /// <summary>
        /// Returns an identified segment specification
        /// </summary>
        /// <param name="id">The segment id</param>
        [MethodImpl(Inline)]
        ref readonly BitFieldSegment SegSpec(E id)
            => ref Segments[evalue<E,byte>(id)];


        /// <summary>
        /// Returns the inclusive range of bit positions of an identified segment
        /// </summary>
        /// <param name="id">The segment id</param>
        [MethodImpl(Inline)]
        public Interval<byte> SegRange(byte index)
        {
            ref readonly var spec = ref skip(Segments, index);
            return ((byte)spec.StartPos, (byte)spec.EndPos);
        }
    }
}
