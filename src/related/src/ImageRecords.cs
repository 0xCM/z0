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
    using System.IO;

    using Windows;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct ImageRecords
    {
        public static Index<MemoryRegion> pages(ReadOnlySpan<MemorySegInfo> src)
        {
            var count = src.Length;
            var buffer = memory.alloc<MemoryRegion>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                fill(skip(src,i), out seek(dst,i));
            return buffer;
        }

        public static ref MemoryRegion fill(in MemorySegInfo src, out MemoryRegion dst)
        {
            var identity = src.Owner;
            if(text.nonempty(identity))
            {
                dst.FullIdentity = identity;
                if(identity.Contains("."))
                    dst.Identity = Path.GetFileName(identity);
                else
                    dst.Identity = identity.Substring(0, root.min(identity.Length, 12));
            }
            else
            {
                dst.Identity = "unknown";
                dst.FullIdentity = "unknown";
            }

            dst.BaseAddress = src.BaseAddress;
            dst.EndAddress = src.EndAddress;
            dst.Size = src.Size;
            dst.Protection = src.Protection;
            dst.Type = src.Type;
            dst.State = src.State;
            return ref dst;
        }

        public static Outcome parse(string src, out MemoryRegion dst)
        {
            dst = default;
            if(text.empty(src))
                return false;

            var count = MemoryRegion.FieldCount;
            var parts = text.split(src,Chars.Pipe).View;
            if(parts.Length != MemoryRegion.FieldCount)
                return (false, Tables.FieldCountMismatch.Format(parts.Length, count));

            var buffer = alloc<Outcome>(count);
            ref var outcomes = ref first(buffer);

            var i=0;
            var j=0;
            seek(outcomes,i++) = DataParser.parse(skip(parts,j++), out dst.Identity);
            seek(outcomes,i++) = DataParser.parse(skip(parts,j++), out dst.BaseAddress);
            seek(outcomes,i++) = DataParser.parse(skip(parts,j++), out dst.EndAddress);
            seek(outcomes,i++) = DataParser.parse(skip(parts,j++), out dst.Size);
            seek(outcomes,i++) = DataParser.eparse(skip(parts,j++), out dst.Type);
            seek(outcomes,i++) = DataParser.eparse(skip(parts,j++), out dst.Protection);
            seek(outcomes,i++) = DataParser.eparse(skip(parts,j++), out dst.State);
            seek(outcomes,i++) = DataParser.parse(skip(parts,j++), out dst.FullIdentity);
            var result = buffer.FirstOrDefault(x => x.Fail);
            return result.IsEmpty ? true : result;
        }

        [MethodImpl(Inline), Op]
        public static void fill(ReadOnlySpan<ProcessModule> src, Span<ProcessModuleRow> dst)
        {
            var count = root.min(src.Length, dst.Length);
            for(var i=0u; i<count; i++)
                fill(skip(src,i), ref seek(dst,i));
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
    }
}