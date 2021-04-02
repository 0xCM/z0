//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly ref struct XedWf
    {
        public static XedWf create(IWfShell wf)
            => new XedWf(wf,new XedWfConfig(wf));

        readonly XedWfConfig Config;

        readonly IWfShell Wf;

        readonly XedDataSource Source;

        readonly ITableArchive Target;

        const string Subject = "xed";

        readonly FS.FolderPath Root;

        public XedWf(IWfShell wf, XedWfConfig config)
        {
            Wf = wf;
            Config = config;
            Source = Xed.sources(Config.Source);
            var db = Wf.Db();
            Target = new DbTables<string>(db, Subject);
            Root = Target.Root;
        }

        public void Dispose()
        {

        }

        public void Run()
        {
            Target.Clear();

            var patterns = ExtractPatterns();
            var summaries = Emit(patterns);
            SaveMnemonics(summaries);
            Xed.emit(Wf, Config, Source);
        }

        public XedPattern[] EmitInstructions(FS.FilePath file)
        {
            const string kind = "instructions";
            var patterns = root.list<XedPattern>();
            var parser = XedSourceParser.Service;
            var flow = Wf.Running(file);
            var parsed = span(parser.ParseInstructions(file));
            for(var j = 0; j<parsed.Length; j++)
            {
                ref readonly var p = ref skip(parsed, j);
                Xed.emit(parsed, Config.InstructionDir + file.FileName);
                patterns.AddRange(p.Patterns);
            }
            Wf.Ran(flow, parsed.Length);
            return patterns.ToArray();
        }

        public XedPattern[] ExtractPatterns()
        {
            var patterns = root.list<XedPattern>();
            var parser = XedSourceParser.Service;
            var files = Source.InstructionFiles.View;
            const string kind = "instructions";
            var count = files.Length;
            try
            {
                for(var i=0; i<count; i++)
                {
                    ref readonly var file = ref skip(files,i);
                    patterns.AddRange(EmitInstructions(file));
                }
            }
            catch(Exception e)
            {
                term.error(e);
            }

            return patterns.ToArray();
        }

        public XedSummaryRow[] Emit(XedPattern[] src)
        {
            var records = Xed.sort(src).Map(p => Xed.row(p));
            var target = Wf.Db().Table<XedSummaryRow>("xed", FS.Csv);
            Tables.emit(records,  target);
            return records;
        }

        void SaveMnemonics(XedSummaryRow[] src)
        {
            var upper = src.Select(s => s.Class).Distinct().OrderBy(x => x).ToArray();
            var dst = Target.TablePath(FS.file("mnemonics", FS.Csv));
            dst.Overwrite(upper);
        }
    }
}