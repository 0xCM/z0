//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct BitfieldModel : IBitfieldModel
    {
        /// <summary>
        /// The bitfield name
        /// </summary>
        public Identifier Name {get;}

        /// <summary>
        /// The number of defined segments
        /// </summary>
        public uint SegCount {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        public uint TotalWidth {get;}

        readonly Index<BitfieldSeg> Data;

        [MethodImpl(Inline)]
        public BitfieldModel(Identifier name, Index<BitfieldSeg> segs, uint width)
        {
            Name = name;
            SegCount = segs.Count;
            TotalWidth = width;
            Data = segs;
        }

        public Span<BitfieldSeg> Segments
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        [MethodImpl(Inline)]
        public ref BitfieldSeg Seg(uint i)
            => ref Data[i];

        public ref BitfieldSeg this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Seg(i);
        }

        [MethodImpl(Inline)]
        public uint SegWidth(uint i)
            => Seg(i).Width;

        [MethodImpl(Inline)]
        public uint SegStart(uint i)
            => Seg(i).Min;

        [MethodImpl(Inline)]
        public uint SegEnd(uint i)
            => Seg(i).Max;
    }
}