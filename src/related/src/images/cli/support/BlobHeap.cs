//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Images
    {
        public readonly struct BlobHeap : IHeap<BlobHeap>
        {
            public HeapKind Kind => HeapKind.Blob;
        }
    }
}