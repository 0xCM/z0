//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    partial struct ImageMaps
    {
        public static Index<LocatedImageRow> EmitProcessLocations(IWfShell wf)
        {
            var dst = wf.Db().IndexTable<LocatedImageRow>();
            var flow = wf.EmittingTable<LocatedImageRow>(dst);
            var rows = ImageMaps.emit(ImageMaps.index(), dst);
            wf.EmittedTable(flow,rows.Count);
            return rows;
        }

        public static Index<LocatedImageRow> emit(Index<LocatedImage> src, FS.FilePath dst)
        {
            var images = index();
            var records = rows(images);
            var target = records.Edit;
            var formatter = Records.formatter<LocatedImageRow>(16);
            var count = records.Length;
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(target,i)));
            return records;
        }

        public static Outcome<WfExecToken> emit(IWfShell wf, ImageMap src, FS.FilePath dst)
        {
            try
            {
                var flow = wf.EmittingFile(dst);
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

                return wf.EmittedFile(flow, icount);

            }
            catch(Exception e)
            {
                wf.Error(e);
                return e;
            }
        }
    }
}