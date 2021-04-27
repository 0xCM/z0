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

    public readonly struct UserStringHeap : IHeap<UserStringHeap>
    {
        public HeapKind Kind => HeapKind.String;
    }
}