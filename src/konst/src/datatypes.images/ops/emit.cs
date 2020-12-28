//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct ImageMaps
    {
        public static Index<LocatedImageRow> emit(LocatedImageIndex src, FS.FilePath dst)
        {
            var images = ImageMaps.current();
            var records = rows(images);
            var target = records.Edit;

            var count = records.Length;
            var spec = Table.renderspec2<LocatedImageRow.Widths>();
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