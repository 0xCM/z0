//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Windows;
    using System.Diagnostics;

    public readonly partial struct ProcessMemory
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