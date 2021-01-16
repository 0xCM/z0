//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static z;

    class Runner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly CmdBuilder Builder;

        readonly IWfDb Db;

        Runner(IWfShell wf)
        {
            Host = WfShell.host(typeof(Runner));
            Wf = wf.WithHost(Host);
            Builder = wf.CmdBuilder();
            Db = wf.Db();
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(WfShell.parts(Index<PartId>.Empty), args);
                var app = new Runner(wf);
                if(args.Length == 0)
                {
                    wf.Status("usage: run <command> [options]");
                    var settings = wf.Settings;
                    wf.Row(settings.Format());
                }
                else
                {
                    if(args.Length == 1 && args[0] == "tests")
                        app.RunTests();
                    else
                    {
                        wf.Status("Dispatching");
                        Reactor.init(wf).Dispatch(args);
                    }
                }

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }


        void CheckFlags()
        {

            var flags = Clr.@enum<Windows.MinidumpType>();
            var summary = flags.Summary();
            var count = summary.FieldCount;
            var details = summary.LiteralDetails;

            if(count == 0)
                Wf.Error("No flags");

            for(var i=0; i<count; i++)
            {
                ref readonly var detail = ref skip(details,i);
                var description = string.Format("{0,-12} | {1,-48} | {2}", detail.Position, detail.Name, detail.ScalarValue.FormatHex());
                Wf.Row(description);
            }
        }

        void SummarizeDataTypes()
        {
            var types = DataTypes.search(Wf.Components);
            var count = types.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var current = ref types[i];
                var content = current.ContentType;
                var container = current.ContainerType;
                var width = current.StorageWidth;
                var description = string.Format("{0,-24} | {1}", container.Name, width);
                Wf.Row(description);
            }
        }

        void SummarizeDump()
        {
            var src = Db.DumpFilePath("capture");
            if(src.Exists)
            {
                var formatter = Records.formatter<Minidump.FileHeader>();
                using var md = Minidump.open(Wf, src);
                var header = formatter.Format(md.Header, RecordFormatKind.KeyValuePairs);
                Wf.Row(header);

                // using var file = MemoryFiles.map(src);
                // Wf.Status($"Mapped file {file.Path} to process memory based at {file.BaseAddress}");
                // ref readonly var header = ref file.One<W.MINIDUMP_HEADER>(0);
                // asci4 sig = header.Signature;
                // Wf.Row(string.Format("Sig:{0}, Version:{1}, NumerOfStreams:{2}, Flags:{3}",
                //     sig, header.Version & ushort.MaxValue, header.NumberOfStreams, header.Flags));
            }
            else
                Wf.Error($"The file {src} does not exist");
        }

        public void RunTests()
        {
            SummarizeDataTypes();
        }
    }
}