//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Diagnostics;
    using System.Reflection;

    using static Part;
    using static memory;

    using A = Z0.Adapters;

    [ApiHost]
    public readonly struct Runtime
    {
        public static ClrAssembly EntryAssembly
        {
            [MethodImpl(Inline), Op]
            get => Assembly.GetEntryAssembly();
        }

        public static A.Process CurrentProcess
        {
            [MethodImpl(Inline), Op]
            get => Process.GetCurrentProcess();
        }

        [Op]
        public static ProcessMemoryMap map(A.Process src)
        {
            var mods = modules(src);
            var count = mods.Length;
            var buffer = memory.alloc<ModuleMemory>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var mod = ref skip(mods,i);
                seek(dst,i) = new ModuleMemory(mod.Path.FileName.WithoutExtension.Format(), mod.BaseAddress, mod.ModuleMemorySize);
            }
            var main = src.MainModule;
            return new ProcessMemoryMap(src.ProcessName, (uint)src.Id, main.BaseAddress, main.ModuleMemorySize, buffer);
        }

        [Op]
        public static ReadOnlySpan<A.ProcessModule> modules(A.Process src)
            => src.Modules.OrderBy(x => x.BaseAddress).Array();

        [Op]
        public static ReadOnlySpan<A.ProcessModule> modules()
            => modules(CurrentProcess);
    }
}