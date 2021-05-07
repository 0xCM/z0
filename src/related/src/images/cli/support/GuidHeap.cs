//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CliHeaps
    {
        public readonly struct GuidHeap : ICliHeap<GuidHeap>
        {
            public CliHeapKind Kind => CliHeapKind.Guid;
        }
    }
}