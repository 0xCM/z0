//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Images
    {
        public readonly struct UserStringHeap : IHeap<UserStringHeap>
        {
            public HeapKind Kind => HeapKind.String;
        }
    }
}