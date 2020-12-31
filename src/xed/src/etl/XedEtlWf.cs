//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    using static z;

    using F = XedPatternField;
    using R = XedPatternRow;
    using api = Xed;

    [ApiHost]
    public readonly ref struct XedWf
    {
        public static XedWf create(IWfShell wf)
            => new XedWf(wf,new XedWfConfig(wf));

        readonly XedWfConfig Config;

        readonly IWfShell Wf;

        readonly XedSources Source;

        readonly ITableArchive Target;

        readonly WfHost Host;

        const string Subject = "xed";

        readonly FS.FolderPath Root;

        public XedWf(IWfShell wf, XedWfConfig config)
        {
            Host = WfShell.host(typeof(XedWf));
            Wf = wf.WithHost(Host);
            Config = config;
            Source = Xed.sources(Config.Source);
            var db = Wf.Db();
            Target = db.TableArchive(Subject);
            Root = Target.Root;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public XedPattern[] EmitInstructions(FS.FilePath file)
        {
            const string kind = "instructions";
            var patterns = list<XedPattern>();
            var parser = XedSourceParser.Service;
            var flow = Wf.Processing(file, kind);
            var parsed = span(parser.ParseInstructions(file));
            for(var j = 0; j<parsed.Length; j++)
            {
                ref readonly var p = ref skip(parsed, j);
                Xed.emit(parsed, Config.InstructionDir + file.FileName);
                patterns.AddRange(p.Patterns);
            }
            Wf.Processed(flow, FS.path(file.Name), kind, parsed.Length);
            return patterns.ToArray();
        }

        public XedPattern[] ExtractPatterns()
        {
            WfStepId step = typeof(XedWf);
            var patterns = list<XedPattern>();
            var parser = XedSourceParser.Service;
            var files = Source.InstructionFiles.View;
            const string kind = "instructions";
            try
            {
                for(var i=0; i<files.Length; i++)
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

        public XedPatternRow[] Emit(XedPattern[] src)
        {
            var records = Xed.sort(src).Map(p => XedTables.row(p));
            Target.Deposit<F,R>(records, Config.SummaryFile);
            return records;
        }

        void SaveMnemonics(XedPatternRow[] src)
        {
            var upper = src.Select(s => s.Class).Distinct().OrderBy(x => x).ToArray();
            var dst = Target.TablePath(FS.file("mnemonics", FileExtensions.Csv));
            dst.Overwrite(upper);
        }

        // [Op]
        // void EmitRules()
        // {
        //     var parser = XedSourceParser.Service;
        //     var sources = @readonly(Source.FunctionFiles);
        //     var kSrc = sources.Length;

        //     var rulepath = Config.Target + FS.file("rules", FileExtensions.Txt);
        //     var funcpath = Config.Target + FS.file("functions", FileExtensions.Txt);
        //     using var rulewriter = rulepath.Writer();
        //     using var funcwriter = funcpath.Writer();

        //     for(var i=0; i<kSrc; i++)
        //     {
        //         ref readonly var src = ref skip(sources,i);
        //         var functions = parser.ParseFunctions(src);
        //         var kFunc = functions.Length;
        //         if(kFunc != 0)
        //         {
        //             api.emit(functions, funcwriter);

        //             var view = @readonly(functions);
        //             for(var j=0; j<kFunc; j++)
        //             {
        //                 ref readonly var ruleset = ref skip(view,j);
        //                 Xed.emit(skip(view,j), rulewriter);
        //                 Wf.Status($"Emitted ruleset {ruleset.Name}");
        //             }
        //         }
        //     }
        // }

        public void Run()
        {
            Target.Clear();

            var patterns = ExtractPatterns();
            var summaries = Emit(patterns);
            SaveMnemonics(summaries);
            //EmitRules();
            Xed.emit(Wf, Config, Source);

        }
    }
}