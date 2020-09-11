//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct SystemProcess
    {
        [MethodImpl(Inline), Op]
        public static Process current()
            => Process.GetCurrentProcess();

        [MethodImpl(Inline), Op]
        public static ProcessModuleData[] modules()
            => modules(current());

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

        [Op]
        public static ProcessModuleData[] modules(Process src)
        {
            var modules = @readonly(src.Modules.Cast<ProcessModule>().Array());
            var count = modules.Length;
            var buffer = alloc<ProcessModuleData>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                map(skip(modules,i), ref seek(dst, i));
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static ref ProcessState map(Process src, ref ProcessState dst)
        {
            dst.Name = src.ProcessName;
            dst.Id = (uint)src.Id;
            dst.Base = src.Handle;
            dst.Capacity = ((ulong)src.MinWorkingSet,(ulong)src.MaxWorkingSet);
            dst.Affinity = (ushort)src.ProcessorAffinity;
            dst.StartTime = src.StartTime;
            dst.TotalRuntime = src.TotalProcessorTime;
            dst.UserRuntime = src.UserProcessorTime;
            map(src.MainModule, ref dst.Main);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ProcessModuleData map(ProcessModule src, ref ProcessModuleData dst)
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
        public static void map(ProcessModule[] src, ProcessModuleData[] dst)
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