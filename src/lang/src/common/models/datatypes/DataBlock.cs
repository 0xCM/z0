//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct DataBlock
    {
        public SegmentKind SegKind {get;}

        public uint SegCount {get;}

        public Identifier Name => "block";

        public BitWidth Width {get;}

        [MethodImpl(Inline)]
        public DataBlock(SegmentKind kind, uint count, BitWidth width)
        {
            SegKind = kind;
            SegCount = count;
            Width = width;
        }
    }
}