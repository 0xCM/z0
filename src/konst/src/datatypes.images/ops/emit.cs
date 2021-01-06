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
        public static Outcome<WfExecToken> emit(IWfShell wf, ImageMap src, FS.FilePath dst)
        {
            try
            {
                var flow = wf.EmittingFile(src, dst);
                using var writer = dst.Writer();

                var f1 = Records.formatter<ProcessState>(16);
                var f2 = Records.formatter<LocatedImageRow>(16);

                writer.WriteLine(string.Format("# {0}", nameof(ProcessState)));
                writer.WriteLine(f1.FormatHeader());
                writer.WriteLine(RP.PageBreak240);
                writer.WriteLine(f1.Format(src.Process));

                writer.WriteLine();

                writer.WriteLine(string.Format("# {0}", nameof(LocatedImageRow)));
                var images = rows(src.Images).View;
                writer.WriteLine(f2.FormatHeader());
                writer.WriteLine(RP.PageBreak240);
                var icount = images.Length;
                for(var i=0; i<icount; i++)
                    writer.WriteLine(f2.Format(skip(images,i)));

                return wf.EmittedFile(flow, src, dst);

            }
            catch(Exception e)
            {
                wf.Error(e);
                return e;
            }
        }

        public static Index<LocatedImageRow> emit(FS.FilePath dst)
            => emit(LocatedImages.index(), dst);

        public static Index<LocatedImageRow> emit(Index<LocatedImage> src, FS.FilePath dst)
        {
            var images = LocatedImages.index();
            var records = rows(images);
            var target = records.Edit;

            var formatter = Records.formatter<LocatedImageFields,LocatedImageRow>();
            var count = records.Length;
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(target,i)));
            return records;
        }

        [Op]
        static Index<LocatedImageRow> rows(Index<LocatedImage> src)
        {
            var count = src.Count;
            var images = src.View;
            var buffer = alloc<LocatedImageRow>(count);
            var summaries = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var dst = ref seek(summaries,i);
                dst.BaseAddress = image.BaseAddress;
                dst.EndAddress = image.EndAddress;
                dst.MemorySize = image.Size;
                dst.PartId = image.PartId;
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
   }
}