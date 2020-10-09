//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Reflection;
    using System.Linq;
    using System.IO;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct ProcessImages
    {
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
        public static LocatedImage[] locate(Process src)
            => src.Modules.Cast<ProcessModule>().Map(locate).OrderBy(x => x.BaseAddress);

        [MethodImpl(Inline), Op]
        public static LocatedImage[] locate()
            => locate(Process.GetCurrentProcess());

        [MethodImpl(Inline), Op]
        public static MemoryAddress @base(IPart src)
        {
            var match =  Path.GetFileNameWithoutExtension(src.Owner.Location);
            var module = SystemProcess.modules().Where(m => Path.GetFileNameWithoutExtension(m.Path.Name) == match).First();
            return module.Base;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<LocatedImageSummary> summaries()
            => summaries(locate());

        [Op]
        public static ReadOnlySpan<LocatedImageSummary> summaries(LocatedImages src)
        {
            var count = src.Count;
            var images = src.View;
            var summaries = span<LocatedImageSummary>(count);
            var system = SystemImages;
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var summary = ref seek(summaries,i);
                var name = image.Name;
                var match = system.First((in ImageToken r) => r.Name == name);
                summary.ImageId = match.IsSome() ? match.Value.Identifier : image.Name.Replace("z0.", EmptyString);
                fill(image, ref summary);

                if(i != 0)
                {
                    ref readonly var prior = ref skip(images, i - 1);
                    var gap = (ulong)(image.BaseAddress - prior.EndAddress);
                    summary.Gap = gap;
                }
            }

            return summaries;
        }

        [Op]
        public static void summarize(LocatedImages src, FS.FilePath dst)
        {
            var system = SystemImages;
            var count = src.Count;
            var images = src.View;
            var fields = Table.columns<LocatedImageField>();
            var header = Table.header(fields);
            var summaries = span<LocatedImageSummary>(count);

            var rows = text.build();
            rows.AppendLine(header);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var summary = ref seek(summaries,i);

                var name = image.Name;
                var match = system.First((in ImageToken r) => r.Name == name);
                var symbolic = match.IsSome() ? match.Value.Identifier : image.Name.Replace("z0.", EmptyString);

                summary.ImageId = symbolic;
                summary.PartId = image.PartId;
                summary.EntryAddress = image.EndAddress;
                summary.BaseAddress = image.BaseAddress;
                summary.EndAddress = image.EndAddress;
                summary.Size = image.Size;

                rows.Append(symbolic.PadRight(fields[0].Width));
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

        [MethodImpl(Inline), Op]
        static void fill(in LocatedImage src, ref LocatedImageSummary dst)
        {
            dst.PartId = src.PartId;
            dst.EntryAddress = src.EndAddress;
            dst.BaseAddress = src.BaseAddress;
            dst.EndAddress = src.EndAddress;
            dst.Size = src.Size;
        }

        [Op]
        public static ReadOnlySpan<ImageToken> SystemImages
        {
            get
            {
                var doc = structured(Assembly.GetExecutingAssembly(), nameof(SystemImages));
                if(doc.RowCount != 0)
                {
                    var dst = sys.alloc<ImageToken>(doc.RowCount);
                    for(var i=0; i<doc.RowCount; i++)
                    {
                        ref readonly var row = ref doc[i];
                        if(row.CellCount >= 2)
                            dst[i] = new ImageToken(row[0], row[1]);
                    }
                    return dst;
                }
                return sys.empty<ImageToken>();
            }
        }

        /// <summary>
        /// Searches for an embedded document with a matching identifier and, if found,
        /// returns the first match; otherwise returns an empty document
        /// </summary>
        /// <param name="match">The resource identifier to match</param>
        [MethodImpl(Inline), Op]
        public static AppResourceDoc structured(Assembly src, string match)
            => ResExtractor.Service(src).MatchDocument(match);
    }
}