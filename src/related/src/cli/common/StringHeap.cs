//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Images
    {
        public readonly struct StringHeap : IHeap<StringHeap>
        {
            public HeapKind Kind => HeapKind.String;
        }
    }
}