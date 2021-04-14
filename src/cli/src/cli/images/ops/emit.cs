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

        public static Index<ProcessImageRow> EmitSummaries(IWfRuntime wf, Timestamp? ts = null)
        {
            var process = Runtime.CurrentProcess;
            var name = process.ProcessName;
            var dst = wf.Db().IndexTable<ProcessImageRow>(string.Format("{0}.{1}", name, (ts ?? root.timestamp()).Format()));
            var flow = wf.EmittingTable<ProcessImageRow>(dst);
            var rows = emit(index(process), dst);
            wf.EmittedTable(flow, rows.Count);
            return rows;
        }

        public static Index<MemoryPageInfo> EmitDetails(IWfRuntime wf, Timestamp? ts = null)
        {
            var process = Runtime.CurrentProcess;
            var name = process.ProcessName;
            var dst = wf.Db().IndexTable<MemoryPageInfo>(name, ts ?? root.timestamp());
            var flow = wf.EmittingTable<MemoryPageInfo>(dst);
            var segments = SystemMemory.snapshot(process);
            Tables.emit(segments,dst);
            wf.EmittedTable(flow, segments.Count);
            return segments;
        }

        public static Index<ProcessImageRow> emit(Index<LocatedImage> src, FS.FilePath dst)
        {
            var records = rows(src);
            var target = records.Edit;
            var formatter = Tables.formatter<ProcessImageRow>(16);
            var count = records.Length;
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(target,i)));
            return records;
        }

        public static Outcome<WfExecToken> emit(IWfRuntime wf, ImageMap src, FS.FilePath dst)
        {
            try
            {
                var flow = wf.EmittingFile(dst);
                using var writer = dst.Writer();

                var f1 = Tables.formatter<ProcessState>(16);
                var f2 = Tables.formatter<ProcessImageRow>(16);

                writer.WriteLine(string.Format("# {0}", nameof(ProcessState)));
                writer.WriteLine(f1.FormatHeader());
                writer.WriteLine(RP.PageBreak240);
                writer.WriteLine(f1.Format(src.Process));
                writer.WriteLine();
                writer.WriteLine(string.Format("# {0}", nameof(ProcessImageRow)));

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