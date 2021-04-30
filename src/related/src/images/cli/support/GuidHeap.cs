//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Images
    {
        public readonly struct GuidHeap : IHeap<GuidHeap>
        {
            public HeapKind Kind => HeapKind.Guid;
        }
    }
}