//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using Windows;

    using static memory;
    using static Part;

    [ApiHost]
    public readonly struct SystemMemory
    {
        [Op]
        public static Index<MemoryRegion> snapshot()
            => ImageRecords.pages(MemoryNode.snapshot().Describe());

        [Op]
        public static Index<MemoryRegion> snapshot(int procid)
            => ImageRecords.pages(MemoryNode.snapshot(procid).Describe());

        [Op]
        public static Index<MemoryRegion> snapshot(Process src)
            => ImageRecords.pages(MemoryNode.snapshot(src.Id).Describe());
    }
}