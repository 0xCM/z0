//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct DataBlockSeqSpec
    {
        public Name Namespace {get;}

        public Name OuterType {get;}

        public Index<DataBlockSpec> Blocks {get;}

        [MethodImpl(Inline)]
        public DataBlockSeqSpec(DataBlockSpec[] src, string ns = "Z0", string outer = "DataBlocks")
        {
            Blocks = src;
            Namespace = ns;
            OuterType = outer;
        }
    }
}