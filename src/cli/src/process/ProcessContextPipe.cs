//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;
    using static ProcessMemory;

    using PCK = ProcessContextFlag;

    partial class XSvc
    {
        [Op]
        public static ProcessContextPipe ProcessContextPipe(this IWfRuntime wf)
            => Z0.ProcessContextPipe.create(wf);
    }

    [ApiHost]
    public partial class ProcessContextPipe : AppService<ProcessContextPipe>
    {
        public ProcessContextPaths Paths {get; private set;}

        protected override void OnInit()
        {
            Paths = Db.CaptureContextRoot();
        }

        public MemorySymbols SymbolizeDetails(in ProcessContext src)
        {
            var details = src.Regions.View;
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
            var summaries = src.Partitions.View;
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
            Paths = dst;
            var summaries = SymbolizeSummaries(src);
            var summarypath = Paths.ProcessPartitionHashPath(src.ProcessName, src.Timestamp, src.Subject);
            EmitHashes(summaries.Addresses, summarypath);

            var details = SymbolizeDetails(src);
            var detailpath = Paths.MemoryRegionHashPath(src.ProcessName, src.Timestamp, src.Subject);
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

        public ProcessContext Emit(FS.FolderPath dst, Timestamp ts, Identifier subject = default, PCK flag = PCK.All)
        {
            Paths = dst;

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
            subject = text.ifempty(subject,"none");
            context.ProcessId = process.Id;
            context.ProcessName = process.ProcessName;
            context.Timestamp = ts;
            context.Subject = subject;
            if(selection.EmitSummary)
            {
                context.PartitionPath = Paths.ProcessPartitionPath(process, ts);
                context.Partitions = EmitPartitions(process, context.PartitionPath);
            }
            if(selection.EmitDetail)
            {
                context.RegionPath = Paths.MemoryRegionPath(process, ts);
                context.Regions = EmitRegions(process, context.RegionPath);
            }
            if(selection.EmitDump)
            {
                context.DumpPath = Db.DumpPath(dst, process, ts);
                EmitDump(process, context.DumpPath);
            }
            if(selection.EmitHashes)
            {
                EmitHashes(context, dst);
            }

            Wf.Ran(flow,"Emitted process context");
            return context;
        }

        public Count EmitDump(Process process, FS.FilePath dst)
        {
            var dumping = Wf.EmittingFile(dst);
            DumpEmitter.emit(process, dst.Format(PathSeparator.BS), DumpTypeOption.Full);
            Wf.EmittedFile(dumping,1);
            return 1;
        }
   }
}