//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct BitFieldModel<T> : IBitfieldModel<T>
        where T : unmanaged
    {
        public Name Name {get;}

        /// <summary>
        /// The number of defined segments
        /// </summary>
        public uint SegmentCount {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        public uint TotalWidth {get;}

        readonly Index<BitFieldPart<T>> _Parts;

        [MethodImpl(Inline)]
        public BitFieldModel(Name name, uint count, uint width, Index<BitFieldPart<T>> parts)
        {
            Name = name;
            SegmentCount = count;
            _Parts = parts;
            TotalWidth = 0;
            TotalWidth = BitfieldSpecs.width(this);
        }

        public ReadOnlySpan<BitFieldPart<T>> Parts
        {
            [MethodImpl(Inline)]
            get => _Parts.View;
        }

        [MethodImpl(Inline)]
        public uint Width(int index)
            => Segment(index).Width;

        [MethodImpl(Inline)]
        public uint Position(int index)
            => bw32(Segment(index).FirstIndex);

        [MethodImpl(Inline)]
        public ref readonly BitFieldPart<T> Segment(int index)
            => ref _Parts[index];
    }
}