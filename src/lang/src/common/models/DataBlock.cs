//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct DataBlock : IDataType
    {
        public SegmentKind SegKind {get;}

        public uint SegCount {get;}

        public Identifier Name => "block";

        public BitSize Width => throw new NotImplementedException();

        [MethodImpl(Inline)]
        public DataBlock(SegmentKind kind, uint count)
        {
            SegKind = kind;
            SegCount = count;
        }
    }
}