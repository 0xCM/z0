//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.IO;
    using System.Reflection;
    using Windows;

    using static memory;
    using static Part;
    using static ProcessMemory;

    [ApiHost]
    public readonly partial struct ImageMemory
    {
        public static Index<SegmentSelection> selection(IWfRuntime wf, ReadOnlySpan<MemoryRegion> src)
        {
            var processor = wf.RegionProcessor();
            processor.Submit(src);
            return processor.Selection;
        }

        [Op]
        public static ProcessImageMap map(Process src)
        {
            var images = locate(src);
            ref readonly var image = ref images.First;
            var count = images.Count;
            Index<MemoryAddress> addresses = alloc<MemoryAddress>(count);
            ref var address = ref addresses.First;
            for(var i=0u; i<count; i++)
                seek(address, i) = skip(image, i).BaseAddress;
            var state = new ProcessState();
            fill(src, ref state);
            return new ProcessImageMap(state, images, addresses.Sort(), modules(src));
        }

        /// <summary>
        /// Captures state information about a specified process
        /// </summary>
        /// <param name="src">The source process</param>
        [MethodImpl(Inline), Op]
        public static ProcessState state(Process src)
        {
            var dst = new ProcessState();
            fill(src, ref dst);
            return dst;
        }

        [Op]
        public static Index<MemoryRegion> regions()
            => ImageMemory.pages(MemoryNode.snapshot().Describe());

        [Op]
        public static Index<MemoryRegion> regions(int procid)
            => ImageMemory.pages(MemoryNode.snapshot(procid).Describe());

        [Op]
        public static Index<MemoryRegion> regions(Process src)
            => ImageMemory.pages(MemoryNode.snapshot(src.Id).Describe());

        public static Index<MemoryRegion> pages(ReadOnlySpan<MemoryRangeInfo> src)
        {
            var count = src.Length;
            var buffer = memory.alloc<MemoryRegion>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                fill(skip(src,i), i, out seek(dst,i));
            return buffer;
        }

        public static ref MemoryRegion fill(in MemoryRangeInfo src, uint index, out MemoryRegion dst)
        {
            var identity = src.Owner;
            dst.Index = index;
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

        [Op]
        public static Index<LocatedImage> locate(Process src)
            => src.Modules.Cast<ProcessModule>().Map(locate).OrderBy(x => x.BaseAddress);

        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from the main module of the executing <see cref='Process'/>
        /// </summary>
        /// <param name="src">The source module</param>
        public static LocatedImage locate()
            => locate(Process.GetCurrentProcess().MainModule);

        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from a specified <see cref='ProcessModule'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [Op]
        public static LocatedImage locate(ProcessModule src)
        {
            var part = ApiPartIdParser.fromFile(src.FileName);
            var entry = (MemoryAddress)src.EntryPointAddress;
            var @base = src.BaseAddress;
            var size = (uint)src.ModuleMemorySize;
            return new LocatedImage(FS.path(src.FileName), part, entry, @base, size);
        }

        [Op]
        public static Index<ProcessModuleRow> modules(Process src)
        {
            var modules = @readonly(src.Modules.Cast<ProcessModule>().Array());
            var count = modules.Length;
            var buffer = alloc<ProcessModuleRow>(count);
            fill(modules, buffer);
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static void fill(ReadOnlySpan<ProcessModule> src, Span<ProcessModuleRow> dst)
        {
            var count = root.min(src.Length, dst.Length);
            for(var i=0u; i<count; i++)
                fill(skip(src,i), ref seek(dst,i));
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

        [Op]
        public static MemoryAddress @base(Assembly src)
            => @base(Path.GetFileNameWithoutExtension(src.Location));

        [MethodImpl(Inline), Op]
        public static MemoryAddress @base(Name procname)
        {
            var match =  procname.Content;
            var module = modules(Process.GetCurrentProcess()).Where(m => Path.GetFileNameWithoutExtension(m.ImagePath.Name) == match).First();
            return module.BaseAddress;
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
            seek(outcomes,i++) = DataParser.parse(skip(parts,j++), out dst.Index);
            seek(outcomes,i++) = DataParser.parse(skip(parts,j++), out dst.Identity);
            seek(outcomes,i++) = DataParser.parse(skip(parts,j++), out dst.BaseAddress);
            seek(outcomes,i++) = DataParser.parse(skip(parts,j++), out dst.EndAddress);
            seek(outcomes,i++) = DataParser.parse(skip(parts,j++), out dst.Size);
            seek(outcomes,i++) = DataParser.eparse(skip(parts,j++), out dst.Type);
            seek(outcomes,i++) = DataParser.eparse(skip(parts,j++), out dst.Protection);
            seek(outcomes,i++) = DataParser.eparse(skip(parts,j++), out dst.State);
            seek(outcomes,i++) = DataParser.parse(skip(parts,j++), out dst.FullIdentity);
            return true;
            // var result = buffer.FirstOrDefault(x => x.Fail);
            // return result.IsEmpty ? true : result;
        }

        [Op]
        public static Index<ProcessPartition> partitions(Index<LocatedImage> src)
        {
            var count = src.Count;
            var images = src.View;
            var buffer = alloc<ProcessPartition>(count);
            var summaries = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var dst = ref seek(summaries,i);
                dst.BaseAddress = image.BaseAddress;
                dst.EndAddress = image.EndAddress;
                dst.Size = image.Size;
                dst.ImageName = image.Name;

                if(i != 0)
                {
                    ref readonly var prior = ref skip(images, i - 1);
                    var gap = (ulong)(image.BaseAddress - prior.EndAddress);
                    dst.Gap = gap;
                }
            }

            return buffer;
        }

        [Op]
        public static Index<ProcessPartition> emit(Index<LocatedImage> src, FS.FilePath dst)
        {
            var records = partitions(src);
            var target = records.Edit;
            var formatter = Tables.formatter<ProcessPartition>(16);
            var count = records.Length;
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(target,i)));
            return records;
        }
    }
}