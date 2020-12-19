//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Linq;

    using static Konst;
    using static z;

    public readonly struct ModuleExtractors
    {
        [Op]
        public static ProcessModuleRecord[] modules(Process src)
        {
            var modules = @readonly(src.Modules.Cast<ProcessModule>().Array());
            var count = modules.Length;
            var buffer = alloc<ProcessModuleRecord>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                map(skip(modules,i), ref seek(dst, i));
            return buffer;
        }

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
        public static ref ProcessModuleRecord map(ProcessModule src, ref ProcessModuleRecord dst)
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
        public static void map(ProcessModule[] src, ProcessModuleRecord[] dst)
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


        /// <summary>
        /// Captures the current process state
        /// </summary>
        /// <param name="src">The source process</param>
        [MethodImpl(Inline), Op]
        public static ProcessState state(Process src)
        {
            var dst = new ProcessState();
            map(src, ref dst);
            return dst;
        }
    }
}