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

    using api = XedWfOps;

    [ApiHost]
    public readonly ref struct XedWf
    {
        public static XedWf create(IWfShell wf)
            => new XedWf(wf,new XedWfConfig(wf));

        readonly XedWfConfig Config;

        readonly XedSettings Settings;

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
            Settings = config.Settings;
            Source = XedWfOps.sources(Config.Source);
            var db = Wf.Db();
            Target = db.TableArchive(Subject);
            Root = Target.Root;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public XedPattern[] ExtractPatterns()
        {
            WfStepId step = typeof(XedWf);
            var patterns = list<XedPattern>();
            var parser = XedSourceParser.Service;
            var files = @readonly(Source.InstructionFiles);
            const string kind = "instructions";
            try
            {
                for(var i=0; i<files.Length; i++)
                {
                    ref readonly var file = ref skip(files,i);
                    Wf.Processing(file, kind);
                    var parsed = span(parser.ParseInstructions(file));
                    for(var j = 0; j<parsed.Length; j++)
                    {
                        ref readonly var p = ref skip(parsed, j);
                        patterns.AddRange(p.Patterns);
                        api.emit(parsed, Config.InstructionDir + file.FileName);
                    }

                    Wf.Processed(FS.path(file.Name), kind, parsed.Length);
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
            var records = api.sort(src).Map(p => api.row(p));
            Target.Deposit<F,R>(records, Config.SummaryFile);
            return records;
        }

        void SaveExtensions(XedPatternRow[] src)
        {
            foreach(var selected in Config.Extensions)
                Target.Deposit<F,R>(api.filter(src, selected), Config.ExtensionFolder, FS.file(XedConst.Name(selected), Config.DataFileExt));
        }

        void SaveCategories(XedPatternRow[] src)
        {
            foreach(var selected in Config.Categories)
                Target.Deposit<F,R>(api.filter(src, selected), Config.CategoryFolder, FS.file(XedConst.Name(selected), Config.DataFileExt));
        }

        void SaveMnemonics(XedPatternRow[] src)
        {
            var upper = src.Select(s => s.Class).Distinct().OrderBy(x => x).ToArray();
            var dst = Target.TablePath(FS.file("mnemonics", FileExtensions.Csv));
            dst.Overwrite(upper);
        }

        [Op]
        void EmitRules()
        {
            var parser = XedSourceParser.Service;
            var sources = @readonly(Source.FunctionFiles);
            var kSrc = sources.Length;

            var rulepath = Config.Target + FS.file("rules", FileExtensions.Txt);
            var funcpath = Config.Target + FS.file("functions", FileExtensions.Txt);
            using var rulewriter = rulepath.Writer();
            using var funcwriter = funcpath.Writer();

            for(var i=0; i<kSrc; i++)
            {
                ref readonly var src = ref skip(sources,i);
                var functions = parser.ParseFunctions(src);
                var kFunc = functions.Length;
                if(kFunc != 0)
                {
                    api.emit(functions, funcwriter);

                    var view = @readonly(functions);
                    for(var j=0; j<kFunc; j++)
                    {
                        ref readonly var ruleset = ref skip(view,j);
                        api.emit(skip(view,j), rulewriter);
                        Wf.Status($"Emitted ruleset {ruleset.Name}");
                    }
                }
            }
        }

        public void Run()
        {
            Target.Clear();
            Target.Clear(Config.FunctionFolder);
            Target.Clear(Config.InstructionFolder);

            var patterns = ExtractPatterns();
            var summaries = Emit(patterns);

            // if(Settings.EmitExtensions)
            // {
            //     Target.Clear(Config.ExtensionFolder);
            //     SaveExtensions(summaries);
            // }

            // if(Settings.EmitCategories)
            // {
            //     Target.Clear(Config.CategoryFolder);
            //     SaveCategories(summaries);
            // }

            if(Settings.EmitMnemonicList)
                SaveMnemonics(summaries);

            if(Settings.EmitRules)
            {
                Target.Clear(Config.RuleFolder);
                EmitRules();
            }
        }
    }
}