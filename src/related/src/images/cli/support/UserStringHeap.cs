//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct CliHeaps
    {
        public readonly struct UserStringHeap : ICliHeap<UserStringHeap>
        {
            public CliHeapKind Kind => CliHeapKind.String;
        }
    }
}