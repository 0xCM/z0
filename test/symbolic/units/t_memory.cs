//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Linq;


    public static class MemoryMap
    {
        public static LocatedImage locate(ProcessModule src)
        {
            var path = FS.path(src.FileName);
            var part = ApiPartIdParser.part(path);
            var entry = (MemoryAddress)src.EntryPointAddress;
            var @base = src.BaseAddress;
            var size = (uint)src.ModuleMemorySize;
            return new LocatedImage(path, part, entry, @base, size);
        }

    }

    public class t_memory : t_symbolic<t_memory>
    {
        public void trace()
        {
            var located = Process.GetCurrentProcess().Modules.Cast<ProcessModule>().Map(MemoryMap.locate).OrderBy(x => x.BaseAddress);
        }
    }
}