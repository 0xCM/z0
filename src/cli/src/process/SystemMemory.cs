//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using Windows;

    [ApiHost]
    public readonly struct SystemMemory
    {
        [Op]
        public static Index<MemoryRegion> regions()
            => ImageRecords.pages(MemoryNode.snapshot().Describe());

        [Op]
        public static Index<MemoryRegion> regions(int procid)
            => ImageRecords.pages(MemoryNode.snapshot(procid).Describe());

        [Op]
        public static Index<MemoryRegion> regions(Process src)
            => ImageRecords.pages(MemoryNode.snapshot(src.Id).Describe());
    }
}