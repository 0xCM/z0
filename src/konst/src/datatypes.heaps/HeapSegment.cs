//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct HeapSegment
    {
        public uint Offset {get;}

        public uint Count {get;}

        [MethodImpl(Inline)]
        public HeapSegment(uint offset, uint count)
        {
            Offset = offset;
            Count = count;
        }
    }
}