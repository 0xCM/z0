//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct MemoryFiles
    {
        [Op]
        public static MemoryFileInfo describe(MemoryFile src)
        {
            var dst = new MemoryFileInfo();
            var fi = src.Path.Info;
            dst.BaseAddress = src.BaseAddress;
            dst.Size = src.Size;
            dst.EndAddress = dst.BaseAddress + dst.Size;
            dst.Path = src.Path;
            dst.CreateTS = fi.CreationTime;
            dst.UpdateTS = fi.LastWriteTime;
            dst.Attributes = fi.Attributes;
            return dst;
        }

    }
}