//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Meta
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct DataBlockSeq
    {
        public Name Namespace {get;}

        public Name OuterType {get;}

        public Index<DataBlock> Blocks {get;}

        [MethodImpl(Inline)]
        public DataBlockSeq(DataBlock[] src, string ns = "Z0", string outer = "DataBlocks")
        {
            Blocks = src;
            Namespace = ns;
            OuterType = outer;
        }
    }
}