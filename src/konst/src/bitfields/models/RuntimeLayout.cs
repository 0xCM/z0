//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static Part;

    partial struct BitFieldParts
    {
        /// <summary>
        /// Characterizes the layout of a bitfield at runtime
        /// </summary>
        public readonly ref struct RuntimeLayout
        {
            readonly Span<BitFieldPart> Data;

            [MethodImpl(Inline)]
            public RuntimeLayout(BitFieldPart[] src)
                => Data = src;

            [MethodImpl(Inline)]
            public static implicit operator RuntimeLayout(BitFieldPart[] src)
                => new RuntimeLayout(src);

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

            public int SegmentCount
            {
                [MethodImpl(Inline)]
                get => Data.Length;
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
        }
    }
}