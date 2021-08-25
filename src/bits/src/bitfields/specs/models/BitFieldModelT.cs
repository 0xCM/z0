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

    public readonly struct BitFieldModel<T>
        where T : unmanaged
    {
        public Identifier Name {get;}

        /// <summary>
        /// The number of defined segments
        /// </summary>
        public uint SegCount {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        public uint TotalWidth {get;}

        readonly Index<BitfieldSeg<T>> Data;

        [MethodImpl(Inline)]
        public BitFieldModel(Identifier name, Index<BitfieldSeg<T>> segments, uint width)
        {
            Name = name;
            SegCount = segments.Count;
            Data = segments;
            TotalWidth = width;
        }

        public ref BitfieldSeg<T> this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public Span<BitfieldSeg<T>> Segments
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        [MethodImpl(Inline)]
        public uint Width(int index)
            => Seg(index).Width;

        [MethodImpl(Inline)]
        public uint Position(int index)
            => bw32(Seg(index).Offset);

        [MethodImpl(Inline)]
        public ref BitfieldSeg<T> Seg(int index)
            => ref Data[index];
    }
}