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

    using static memory;
    using static Part;

    using PCK = ProcessContextFlag;

    partial class XSvc
    {
        [Op]
        public static ProcessContextPipe ProcessContextPipe(this IWfRuntime wf)
            => Z0.ProcessContextPipe.create(wf);
    }

    [ApiHost]
    public class ProcessContextPipe : WfService<ProcessContextPipe>
    {
        [Op]
        public static Index<ProcessModuleRow> modules(Process src)
        {
            var modules = @readonly(src.Modules.Cast<ProcessModule>().Array());
            var count = modules.Length;
            var buffer = alloc<ProcessModuleRow>(count);
            ImageRecords.fill(modules, buffer);
            return buffer;
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

        /// <summary>
        /// Captures the current process state
        /// </summary>
        /// <param name="src">The source process</param>
        [MethodImpl(Inline), Op]
        public static ProcessState state(Process src)
        {
            var dst = new ProcessState();
            ImageRecords.fill(src, ref dst);
            return dst;
        }

        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from the main module of the executing <see cref='Process'/>
        /// </summary>
        /// <param name="src">The source module</param>
        public static LocatedImage locate()
            => locate(Process.GetCurrentProcess().MainModule);

        [Op]
        public static Index<LocatedImage> locate(Process src)
            => src.Modules.Cast<ProcessModule>().Map(locate).OrderBy(x => x.BaseAddress);

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
        public static ImageMap map(Process src)
        {
            var images = ProcessContextPipe.locate(src);
            ref readonly var image = ref images.First;
            var count = images.Count;
            Index<MemoryAddress> addresses = alloc<MemoryAddress>(count);
            ref var address = ref addresses.First;
            for(var i=0; i<count; i++)
                seek(address,i) = skip(image,i).BaseAddress;
            var state = new ProcessState();
            ImageRecords.fill(src, ref state);
            return new ImageMap(state, images, addresses.Sort(), modules(src));
        }

        public MemorySymbols SymbolizeDetails(in ProcessContext src)
        {
            var details = src.Details.View;
            var count = details.Length;
            var symbols = MemorySymbols.alloc(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var detail = ref skip(details,i);
                symbols.Deposit(detail.BaseAddress, detail.Size, detail.Identity.Format());
            }
            return symbols;
        }

        public MemorySymbols SymbolizeSummaries(in ProcessContext src)
        {
            var summaries = src.Summaries.View;
            var count = summaries.Length;
            var symbols = MemorySymbols.alloc(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var summary = ref skip(summaries,i);
                symbols.Deposit(summary.BaseAddress, summary.Size, summary.ImageName.Format());
            }
            return symbols;
        }

        public void EmitHashes(in ProcessContext src, FS.FolderPath dst)
        {
            var summaries = SymbolizeSummaries(src);
            var summarypath = SummaryHashPath(dst, src.ProcessName, src.Timestamp, src.Subject);
            EmitHashes(summaries.Addresses, summarypath);

            var details = SymbolizeDetails(src);
            var detailpath = DetialHashPath(dst, src.ProcessName, src.Timestamp, src.Subject);
            EmitHashes(details.Addresses, detailpath);
        }

        public Index<AddressHash> EmitHashes(ReadOnlySpan<MemoryAddress> addresses, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<AddressHash>(dst);
            var count = (uint)addresses.Length;
            var buffer = alloc<AddressHash>(count);
            memory.hash(addresses,buffer);
            Tables.emit(buffer, dst);
            Wf.EmittedTable(flow, count);
            return buffer;
        }

        [Op]
        public static Index<ProcessImageRow> rows(Index<LocatedImage> src)
        {
            var count = src.Count;
            var images = src.View;
            var buffer = alloc<ProcessImageRow>(count);
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

        [Op ]
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

        [MethodImpl(Inline)]
        public static bit enabled(PCK src, PCK flag)
            => (src & flag) != 0;

        [MethodImpl(Inline)]
        public static ProcessContextFlags flags(PCK src)
        {
            var options = new ProcessContextFlags();
            options.EmitSummary = enabled(src,PCK.Summary);
            options.EmitDetail= enabled(src,PCK.Detail);
            options.EmitDump= enabled(src,PCK.Dump);
            options.EmitHashes = enabled(src,PCK.Hashes);
            return options;
        }

        [Op]
        public MemoryRange EmitImageContent(Assembly src)
        {
            var rowsize = ImageContent.RowDataSize;
            var dst = Db.Table(ImageContent.TableId, src.GetSimpleName());
            var flow = Wf.EmittingTable<ImageContent>(dst);
            var @base = ProcessContextPipe.@base(src);
            var formatter = HexFormats.data(@base, rowsize);
            var path = FS.path(src.Location);
            using var stream = path.Reader();
            using var reader = stream.BinaryReader();
            using var writer = dst.Writer();
            writer.WriteLine(text.concat($"Address".PadRight(12), RP.SpacedPipe, "Data"));
            var buffer = alloc<byte>(rowsize);
            var k = Read(reader, buffer);
            var offset = MemoryAddress.Zero;
            var lines = 0;
            while(k != 0)
            {
                writer.WriteLine(formatter.FormatLine(buffer, offset, Chars.Pipe));

                offset += k;
                lines++;

                buffer.Clear();
                k = Read(reader, buffer);
            }

            Wf.EmittedTable<ImageContent>(flow, lines);
            return (@base, @base + offset);
        }

        [MethodImpl(Inline)]
        uint Read(BinaryReader src, Span<byte> dst)
            => (uint)src.Read(dst);

        public ProcessContext Emit(Identifier subject = default, PCK flag = PCK.All)
        {
            var dst = Db.ProcessContextRoot();
            var emitter = Wf.ProcessContextPipe();
            return emitter.Emit(dst, subject, flag);
        }

        public ProcessContext Emit(FS.FolderPath dst, Identifier subject = default, PCK flag = PCK.All)
        {
            var selection = flags(flag);
            if(selection.IsEmpty)
            {
                Wf.Warn("No options have been specified");
                return default;
            }

            var flow = Wf.Running(string.Format("Emitting process context with options {0}", flag));
            var context = new ProcessContext();
            var process = Runtime.CurrentProcess;
            var name = process.ProcessName;
            var ts = root.timestamp();
            subject = text.ifempty(subject,"none");
            context.ProcessId = process.Id;
            context.ProcessName = process.ProcessName;
            context.Timestamp = ts;
            context.Subject = subject;
            if(selection.EmitSummary)
            {
                context.SummaryPath = SummaryPath(dst, process, ts, subject);
                context.Summaries = EmitSummaries(process, context.SummaryPath);
            }
            if(selection.EmitDetail)
            {
                context.DetailPath = DetailPath(dst, process,ts, subject);
                context.Details = EmitDetails(process, context.DetailPath);
            }
            if(selection.EmitDump)
            {
                context.DumpPath = DumpPath(dst, process,ts, subject);
                EmitDump(process, context.DumpPath);
            }
            if(selection.EmitHashes)
            {
                EmitHashes(context, dst);
            }

            Wf.Ran(flow,"Emitted process context");
            return context;
        }

        public FS.FileName DumpFile(Process process, Timestamp ts, Identifier subject)
            => FS.file(string.Format("process.dump.{0}.{1}.{2}", text.ifempty(subject, process.ProcessName),  process.ProcessName, ts.Format()), FS.Dmp);

        public FS.FilePath DumpPath(FS.FolderPath dst, Process process, Timestamp ts, Identifier subject)
            => dst + FS.folder(process.ProcessName) + DumpFile(process, ts, subject);

        public FS.FileName SummaryHashFile(string process, Timestamp ts, Identifier subject)
            => FS.file(string.Format("process.summary.addresses.{0}.{1}.{2}", text.ifempty(subject, process), process, ts.Format()), FS.Csv);

        public FS.FileName DetailHashFile(string process, Timestamp ts, Identifier subject)
            => FS.file(string.Format("process.detail.addresses.{0}.{1}.{2}", text.ifempty(subject, process), process, ts.Format()), FS.Csv);

        public FS.FileName DetailFile(Process process, Timestamp ts, Identifier subject)
            => FS.file(string.Format("process.detail.{0}.{1}.{2}", text.ifempty(subject, process.ProcessName), process.ProcessName, ts.Format()), FS.Csv);

        public FS.FilePath DetialHashPath(FS.FolderPath dst, string process, Timestamp ts, Identifier subject)
            => dst + FS.folder(process) + DetailHashFile(process, ts, subject);

        public FS.FilePath SummaryHashPath(FS.FolderPath dst, string process, Timestamp ts, Identifier subject)
            => dst + FS.folder(process) + SummaryHashFile(process, ts, subject);

        public FS.FilePath DetailPath(FS.FolderPath dst, Process process, Timestamp ts, Identifier subject)
            => dst + FS.folder(process.ProcessName) + DetailFile(process, ts, subject);

        public FS.FileName SummaryFile(Process process, Timestamp ts, Identifier subject)
            => FS.file(string.Format("process.summary.{0}.{1}.{2}", text.ifempty(subject, process.ProcessName),  process.ProcessName, ts.Format()), FS.Csv);

        public FS.FilePath SummaryPath(FS.FolderPath dst, Process process, Timestamp ts, Identifier subject)
            => dst + FS.folder(process.ProcessName) + SummaryFile(process,ts, subject);

        public Count EmitDump(Process process, FS.FilePath dst)
        {
            var dumping = Wf.EmittingFile(dst);
            DumpEmitter.emit(process, dst.Format(PathSeparator.BS), DumpTypeOption.Full);
            Wf.EmittedFile(dumping,1);
            return 1;
        }

        public Index<ProcessImageRow> EmitSummaries(Process process, FS.FilePath dst)
        {
            var summaries = rows(locate(process));
            EmitSummaries(summaries,dst);
            return summaries;
        }

        public Count EmitSummaries(Index<ProcessImageRow> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<ProcessImageRow>(dst);
            var count = Tables.emit(src,dst);
            Wf.EmittedTable(flow,count);
            return count;
        }

        public Index<MemoryRegion> EmitDetails(Process process, FS.FilePath dst)
        {
            var details = WinMem.snapshot(process);
            EmitDetails(details,dst);
            return details;
        }

        public Count EmitDetails(Index<MemoryRegion> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<MemoryRegion>(dst);
            var count = Tables.emit(src,dst);
            Wf.EmittedTable(flow,count);
            return count;
        }
    }
}