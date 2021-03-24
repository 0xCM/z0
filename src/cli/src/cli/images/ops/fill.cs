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
    using static memory;

    partial struct ImageMaps
    {
        [MethodImpl(Inline), Op]
        public static void fill(ReadOnlySpan<ProcessModule> src, Span<ProcessModuleRow> dst)
        {
            var count = root.min(src.Length, dst.Length);
            for(var i=0u; i<count; i++)
                fill(skip(src,i), ref seek(dst,i));
        }

        [MethodImpl(Inline), Op]
        public static void fill(Process[] src, ProcessState[] dst)
        {
            var count = root.min(src.Length, dst.Length);
            ref readonly var s = ref first(span(src));
            ref var t = ref first(span(dst));
            for(var i=0u; i<count; i++)
                fill(skip(s,i), ref seek(t,i));
        }

        [MethodImpl(Inline), Op]
        public static ref ProcessModuleRow fill(ProcessModule src, ref ProcessModuleRow dst)
        {
            dst.ImageName = src.ModuleName;
            dst.BaseAddress = src.BaseAddress;
            dst.EntryAddress = src.EntryPointAddress;
            dst.ImagePath = FS.path(src.FileName);
            dst.MemorySize = src.ModuleMemorySize;
            dst.Version = root.pair((uint)src.FileVersionInfo.FileMajorPart, (uint)src.FileVersionInfo.FileMinorPart);
            return ref dst;
        }

        [Op]
        public static ref ProcessState fill(Process src, ref ProcessState dst)
        {
            dst.ImageName = src.ProcessName;
            dst.ProcessId = (uint)src.Id;
            dst.BaseAddress = src.MainModule.BaseAddress;
            dst.MinWorkingSet =(ulong)src.MinWorkingSet;
            dst.MaxWorkingSet = (ulong)src.MaxWorkingSet;
            dst.Affinity = (ulong)src.ProcessorAffinity;
            dst.StartTime = src.StartTime;
            dst.TotalRuntime = src.TotalProcessorTime;
            dst.UserRuntime = src.UserProcessorTime;
            dst.ImagePath = FS.path(src.MainModule.FileName);
            dst.MemorySize = src.MainModule.ModuleMemorySize;
            dst.ImageVersion = root.pair((uint)src.MainModule.FileVersionInfo.FileMajorPart, (uint)src.MainModule.FileVersionInfo.FileMinorPart);
            dst.EntryAddress = src.MainModule.EntryPointAddress;
            dst.VirtualSize = src.VirtualMemorySize64;
            dst.MaxVirtualSize = src.PeakVirtualMemorySize64;
            return ref dst;
        }
    }
}