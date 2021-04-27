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

    public readonly struct StringHeap : IHeap<StringHeap>
    {
        public HeapKind Kind => HeapKind.String;
    }
}