//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using Windows;

    using static Images;

    [ApiHost]
    public readonly struct SystemMemory
    {
        [Op]
        public static Index<MemoryRegion> regions()
            => Images.pages(MemoryNode.snapshot().Describe());

        [Op]
        public static Index<MemoryRegion> regions(int procid)
            => Images.pages(MemoryNode.snapshot(procid).Describe());

        [Op]
        public static Index<MemoryRegion> regions(Process src)
            => Images.pages(MemoryNode.snapshot(src.Id).Describe());
    }
}