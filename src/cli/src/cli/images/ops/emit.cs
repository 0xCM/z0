//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    partial class XSvc
    {
        [Op]
        public static ProcessContextEmitter ProcessContextEmitter(this IWfRuntime wf)
            => Z0.ProcessContextEmitter.create(wf);
    }

    public class ProcessContextEmitter : WfService<ProcessContextEmitter>
    {
        public ProcessContext Emit(FS.FolderPath dst, Timestamp? ts = null)
        {
            var flow = Wf.Running("Emitting process context");
            var context = new ProcessContext();
            var process = Runtime.CurrentProcess;
            var name = process.ProcessName;
            var _ts = ts ?? root.timestamp();
            context.ProcessId = process.Id;
            context.ProcessName = process.ProcessName;
            context.SummaryPath = dst + FS.file(string.Format("process.summary.{0}.{1}",  name,_ts.Format()), FS.Csv);
            context.DetailPath = dst + FS.file(string.Format("process.detail.{0}.{1}",  name, _ts.Format()), FS.Csv);
            context.DumpPath = dst + FS.file(string.Format("process.dump.{0}.{1}",  name,_ts.Format()), FS.Dmp);
            context.Summaries = ImageMaps.rows(ImageMaps.index(process));

            Emit(context.Summaries, context.SummaryPath);

            context.Details = WinMem.snapshot(process);
            Emit(context.Details, context.DetailPath);

            var dumping = Wf.EmittingFile(context.DumpPath);
            DumpEmitter.emit(process, context.DumpPath.Format(PathSeparator.BS), DumpTypeOption.Full);
            Wf.EmittedFile(dumping,1);

            Wf.Ran(flow,"Emitted process context");
            return context;
        }

        Count Emit(Index<ProcessImageRow> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<ProcessImageRow>(dst);
            var count = ImageMaps.emit(src,dst);
            Wf.EmittedTable(flow,count);
            return count;
        }

        Count Emit(Index<MemoryPageInfo> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<MemoryPageInfo>(dst);
            var count = Tables.emit(src,dst);
            Wf.EmittedTable(flow,count);
            return count;
        }

    }

    public struct ProcessContext
    {
        public int ProcessId;

        public string ProcessName;

        public Index<ProcessImageRow> Summaries;

        public FS.FilePath SummaryPath;

        public Index<MemoryPageInfo> Details;

        public FS.FilePath DetailPath;

        public FS.FilePath DumpPath;
    }

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
            var segments = WinMem.snapshot(process);
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

        public static Count emit(ReadOnlySpan<ProcessImageRow> src, FS.FilePath dst)
        {
            var formatter = Tables.formatter<ProcessImageRow>(16);
            var count = src.Length;
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(src,i)));
            return count;
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