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
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct ProcessImages
    {
        [MethodImpl(Inline), Op]
        public static LocatedImages locate()
            => locate(Process.GetCurrentProcess());

        public static ReadOnlySpan<ProcessModule> modules(Process src)
            => src.Modules.Cast<ProcessModule>().Array();

        [MethodImpl(Inline), Op]
        public static LocatedImages locate(Process src)
            => src.Modules.Cast<ProcessModule>().Map(locate).OrderBy(x => x.BaseAddress);

        [Op]
        public static ref EmitImageContentCmd specify(IWfShell wf, ProcessModule src, ref EmitImageContentCmd cmd)
        {
            var located = locate(src);
            cmd.Source = located;
            cmd.Target = wf.Db().Table(ImageContentRecord.TableId, located.ImagePath.FileName.WithoutExtension);
            return ref cmd;
        }

        [Op]
        public static void specify(IWfShell wf, Process src, out Index<EmitImageContentCmd> buffer)
        {
            var pmods = modules(src);
            var count = pmods.Length;
            buffer = sys.alloc<EmitImageContentCmd>(count);
            var dst = buffer.Edit;
            for(var i=0; i <count; i++)
                specify(wf, skip(pmods,i) , ref seek(dst,i));
        }

        [MethodImpl(Inline)]
        public static EmitImageContentCmd define(LocatedImage src, FS.FilePath dst)
        {
            var cmd = new EmitImageContentCmd();
            cmd.Source = src;
            cmd.Target = dst;
            return cmd;
        }

        [MethodImpl(Inline)]
        public static EmitImageContentCmd define(IWfShell wf, LocatedImage src)
            => define(src, wf.Db().Table(ImageContentRecord.TableId, src.ImagePath.FileName.WithoutExtension));

        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from a specified <see cref='ProcessModule'/>
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static LocatedImage locate(ProcessModule src)
        {
            var path = FS.path(src.FileName);
            var part = ApiPartIdParser.part(path);
            var entry = (MemoryAddress)src.EntryPointAddress;
            var @base = src.BaseAddress;
            var size = (uint)src.ModuleMemorySize;
            return new LocatedImage(path, part, entry, @base, size);
        }

        [MethodImpl(Inline), Op]
        public static MemoryAddress @base(IPart src)
        {
            var match =  Path.GetFileNameWithoutExtension(src.Owner.Location);
            var module = SystemProcess.modules().Where(m => Path.GetFileNameWithoutExtension(m.Path.Name) == match).First();
            return module.Base;
        }

        [MethodImpl(Inline), Op]
        public static MemoryAddress @base(Assembly src)
        {
            var match =  Path.GetFileNameWithoutExtension(src.Location);
            var module = SystemProcess.modules().Where(m => Path.GetFileNameWithoutExtension(m.Path.Name) == match).First();
            return module.Base;
        }

        [Op]
        public static void summarize(LocatedImages src, FS.FilePath dst)
        {
            var count = src.Count;
            var images = src.View;
            var fields = Table.columns<LocatedImageRow.Fields>();
            var header = Table.header(fields);
            var summaries = span<LocatedImageRow>(count);

            var rows = text.build();
            rows.AppendLine(header);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var summary = ref seek(summaries,i);

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
        }
    }
}