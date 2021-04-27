//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Relations;

    public readonly struct GuidHeap : IHeap<GuidHeap>
    {
        public HeapKind Kind => HeapKind.Guid;
    }
}