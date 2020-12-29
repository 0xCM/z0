//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Part;
    using static z;

    partial struct ImageMaps
    {
        [Op]
        public static ImageMap map(Process src)
        {
            var images = index(src);
            ref readonly var image = ref images.First;
            var count = images.Count;
            var locations = sys.alloc<MemoryAddress>(count);
            ref var location = ref first(locations);
            for(var i=0; i<count; i++)
                seek(location,i) = skip(image,i).BaseAddress;
            var state = new ProcessState();
            map(src, ref state);
            return load(state, images, locations, modules(src));
        }

        [Op]
        public static ImageMap map()
            => map(CurrentProcess.Current);

        [MethodImpl(Inline), Op]
        public static ref ProcessState map(Process src, ref ProcessState dst)
        {
            dst.ProcessName = src.ProcessName;
            dst.ProcessId = (uint)src.Id;
            dst.BaseAddress = src.Handle;
            dst.Capacity = ((ulong)src.MinWorkingSet,(ulong)src.MaxWorkingSet);
            dst.Affinity = (ushort)src.ProcessorAffinity;
            dst.StartTime = src.StartTime;
            dst.TotalRuntime = src.TotalProcessorTime;
            dst.UserRuntime = src.UserProcessorTime;
            dst.ImagePath = FS.path(src.MainModule.FileName);
            dst.MemorySize = src.MainModule.ModuleMemorySize;
            dst.ImageVersion = pair((uint)src.MainModule.FileVersionInfo.FileMajorPart, (uint)src.MainModule.FileVersionInfo.FileMinorPart);
            dst.EntryAddress = src.MainModule.EntryPointAddress;
            map(src.MainModule, ref dst.Main);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ProcessModuleRow map(ProcessModule src, ref ProcessModuleRow dst)
        {
            dst.Name = src.ModuleName;
            dst.Base = src.BaseAddress;
            dst.Entry = src.EntryPointAddress;
            dst.Path = FS.path(src.FileName);
            dst.Size = src.ModuleMemorySize;
            dst.Version = pair((uint)src.FileVersionInfo.FileMajorPart, (uint)src.FileVersionInfo.FileMinorPart);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static void map(ProcessModule[] src, ProcessModuleRow[] dst)
        {
            var count = min(src.Length, dst.Length);
            ref readonly var s = ref first(span(src));
            ref var t = ref first(span(dst));
            for(var i=0u; i<count; i++)
                map(skip(s,i), ref seek(t,i));
        }

        [MethodImpl(Inline), Op]
        public static void map(Process[] src, ProcessState[] dst)
        {
            var count = min(src.Length, dst.Length);
            ref readonly var s = ref first(span(src));
            ref var t = ref first(span(dst));
            for(var i=0u; i<count; i++)
                map(skip(s,i), ref seek(t,i));
        }
    }
}