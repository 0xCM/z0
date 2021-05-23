//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using Microsoft.Diagnostics.Runtime;

    using static core;

    using DP = DiagnosticProcessors;
    using DR = DiagnosticRecords;

    public sealed class DumpParser : AppService<DumpParser>
    {
        DumpPaths DumpPaths;

        public DumpParser()
        {

        }

        protected override void OnInit()
        {
            DumpPaths = Db.DumpPaths();
        }

        public void ParseDump()
        {
            var current = DumpPaths.CurrentDump();
            if(current.IsNonEmpty)
            {
                var flow = Wf.Running(string.Format("Parsing dump {0}", current.FileName));
                ParseDump(current);
                Wf.Ran(flow);
            }
            else
                Wf.Warn(string.Format("No *.{0} files were found in {1}", FS.Dmp, DumpPaths.InputRoot.Format(PathSeparator.FS)));
        }

        void Emit(ProcDumpIdentity id, ReadOnlySpan<DR.ModuleInfo> src)
        {
            var outdir = DumpPaths.OutputDir(id);
            var count = src.Length;
            var dst = Db.Table<DR.ModuleInfo>(outdir);
            var emitting = Wf.EmittingTable<DR.ModuleInfo>(dst);
            using var log = dst.Writer();
            var formatter = Tables.formatter<DR.ModuleInfo>(DR.ModuleInfo.RenderWidths);
            log.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(src,i);
                log.WriteLine(formatter.Format(row));
            }
        }

        public void ParseDump(FS.FilePath src)
        {
            using var dataTarget = DataTarget.LoadDump(src.Name);
            using var runtime = dataTarget.ClrVersions.Single().CreateRuntime();

            var id = ProcDumpIdentity.from(src);
            if(id.IsNonEmpty)
            {
                var running = Wf.Running(string.Format("Parsing {0}", src.ToUri()));
                var modules = runtime.EnumerateModules().Array();
                var sink = EmissionSink.create(GetType());
                var processor = DP.module(sink);
                processor.Process(modules);
                Emit(id, processor.Processed());

                Wf.Ran(running, string.Format("Parsed {0}", src.ToUri()));
            }
            else
            {
                Wf.Error(string.Format("Could not identify {0}", src.ToUri()));
            }
        }
    }
}