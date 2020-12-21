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

    using static Konst;
    using static z;

    public readonly struct LocatedImages
    {
        [MethodImpl(Inline), Op]
        public static MemoryAddress @base(IPart src)
        {
            var match =  Path.GetFileNameWithoutExtension(src.Owner.Location);
            var modules = records(Process.GetCurrentProcess());
            var module = modules.Where(m => Path.GetFileNameWithoutExtension(m.Path.Name) == match).First();
            return module.Base;
        }

        [MethodImpl(Inline), Op]
        public static LocatedImageIndex current()
            => LocatedImages.modules(Process.GetCurrentProcess());

        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from a specified <see cref='ProcessModule'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [Op]
        public static LocatedImage locate(ProcessModule src)
        {
            var path = FS.path(src.FileName);
            var part = ApiPartIdParser.part(path);
            var entry = (MemoryAddress)src.EntryPointAddress;
            var @base = src.BaseAddress;
            var size = (uint)src.ModuleMemorySize;
            return new LocatedImage(path, part, entry, @base, size);
        }

        public static LocatedImageIndex modules(Process src)
            => src.Modules.Cast<ProcessModule>().Map(locate).OrderBy(x => x.BaseAddress);

        [Op]
        public static ImageMap map(Process src)
        {
            var images = modules(src);
            ref readonly var image = ref images.First;
            var count = images.Count;
            var locations = sys.alloc<MemoryAddress>(count);
            ref var location = ref first(locations);
            for(var i=0; i<count; i++)
                seek(location,i) = skip(image,i).BaseAddress;
            return new ImageMap(images, memory.sort(locations));
        }

        [Op]
        public static Index<LocatedImageRow> emit(LocatedImageIndex src, FS.FilePath dst)
        {
            var count = src.Count;
            var images = src.View;
            var fields = Table.columns<LocatedImageRow.Fields>();
            var header = Table.header(fields);
            var buffer = alloc<LocatedImageRow>(count);
            var target = span(buffer);
            var rows = text.build();

            rows.AppendLine(header);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var summary = ref seek(target,i);

                var name = image.Name;
                summary.ImageName = name;
                summary.PartId = image.PartId;
                summary.EntryAddress = image.EndAddress;
                summary.BaseAddress = image.BaseAddress;
                summary.EndAddress = image.EndAddress;
                summary.Size = image.Size;

                rows.Append(name.PadRight(fields[0].Width));
                rows.Append(SpacePipe);
                rows.Append(image.PartId == 0 ? EmptyString.PadRight(fields[1].Width) : image.PartId.Format().PadRight(fields[1].Width));
                rows.Append(SpacePipe);
                rows.Append(image.EntryAddress.Format().PadRight(fields[2].Width));
                rows.Append(SpacePipe);
                rows.Append(image.BaseAddress.Format().PadRight(fields[3].Width));
                rows.Append(SpacePipe);
                rows.Append(image.EndAddress.Format().PadRight(fields[4].Width));
                rows.Append(SpacePipe);
                rows.Append(image.Size.Format().PadRight(fields[5].Width));
                rows.Append(SpacePipe);

                if(i == 0)
                    rows.Append(0.ToString());
                else
                {
                    ref readonly var prior = ref skip(images, i - 1);
                    var gap = (ulong)(image.BaseAddress - prior.EndAddress);
                    summary.Gap = gap;
                    rows.Append(gap.ToString("#,#"));
                }

                rows.Append(Eol);
            }

            using var writer = dst.Writer();
            writer.Write(rows.ToString());
            return buffer;
        }

        [Op]
        public static ProcessModuleRecord[] records(Process src)
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

        public static Index<LocatedImageRow> emit2(LocatedImageIndex src, FS.FilePath dst)
        {
            var images = LocatedImages.current();
            var records = rows(images);
            var target = records.Edit;

            var count = records.Length;
            var spec = Table.renderspec2<LocatedImageRow.Fields>();
            using var writer = dst.Writer();
            writer.WriteLine(spec.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(target,i);
                writer.Write(row.ImageName.Format().PadRight(spec[0].Width));
                writer.Write(row.PartId.Format().PadRight(spec[1].Width));
                writer.Write(row.EntryAddress.Format().PadRight(spec[2].Width));
                writer.Write(row.BaseAddress.Format().PadRight(spec[3].Width));
                writer.Write(row.EndAddress.Format().PadRight(spec[4].Width));
                writer.Write(row.Size.Format().PadRight(spec[5].Width));
                writer.Write(row.Gap.Format().PadRight(spec[6].Width));
                writer.WriteLine();
            }
            return records;
        }

        [Op]
        static Index<LocatedImageRow> rows(LocatedImageIndex src)
        {
            var count = src.Count;
            var images = src.View;
            var buffer = alloc<LocatedImageRow>(count);
            var summaries = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var summary = ref seek(summaries,i);
                var name = image.Name;
                summary.ImageName = name;
                fill(image, ref summary);

                if(i != 0)
                {
                    ref readonly var prior = ref skip(images, i - 1);
                    var gap = (ulong)(image.BaseAddress - prior.EndAddress);
                    summary.Gap = gap;
                }
            }

            return buffer;
        }

        [MethodImpl(Inline), Op]
        static void fill(in LocatedImage src, ref LocatedImageRow dst)
        {
            dst.ImageName = src.Name;
            dst.PartId = src.PartId;
            dst.EntryAddress = src.EndAddress;
            dst.BaseAddress = src.BaseAddress;
            dst.EndAddress = src.EndAddress;
            dst.Size = src.Size;
        }
    }
}