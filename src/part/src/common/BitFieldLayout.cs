//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Characterizes the layout of a bitfield
    /// </summary>
    public readonly struct BitFieldLayout
    {
        readonly BitFieldPart[] Data;

        [MethodImpl(Inline)]
        public BitFieldLayout(BitFieldPart[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator BitFieldLayout(BitFieldPart[] src)
            => new BitFieldLayout(src);

        public ref BitFieldPart FirstSegment
        {
            [MethodImpl(Inline)]
            get => ref Data[0];
        }

        public ref BitFieldPart LastSegment
        {
            [MethodImpl(Inline)]
            get => ref Data[SegmentCount - 1];
        }

        public uint SegmentCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public Span<BitFieldPart> Segments
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref BitFieldPart this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref BitFieldPart this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public BitFieldPart[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}