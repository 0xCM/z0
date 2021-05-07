//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct CliRecords
    {
        public readonly struct BlobHeap : ICliHeap<BlobHeap>
        {
            public CliHeapKind Kind => CliHeapKind.Blob;
        }
    }
}