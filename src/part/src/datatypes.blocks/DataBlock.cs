//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct DataBlockSpec
    {
        public uint BlockIndex {get;}

        public ulong Partition {get;}

        public Name Name => "Block" + BlockIndex.ToString();

        [MethodImpl(Inline)]
        public DataBlockSpec(uint index, ulong partition)
        {
            BlockIndex = index;
            Partition = partition;
        }
    }
}