//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static z;
    using static Konst;

    using xed_ext = xed_extension_enum_t;
    using xed_cat = xed_category_enum_t;

    using F = XedPatternField;
    using R = XedPatternRow;

    [ApiHost]
    public readonly ref struct XedEtlWf
    {
        public static XedEtlWf create(IWfShell wf)
            => new XedEtlWf(wf,new XedWfConfig(wf));

        readonly XedWfConfig Config;

        readonly XedSettings Settings;

        readonly IWfShell Wf;

        readonly XedSourceArchive Source;

        readonly XedStageArchive Stage;

        readonly ITableArchive Target;

        public XedEtlWf(IWfShell wf, XedWfConfig config)
        {
            Wf = wf;
            Config = config;
            Settings = config.Settings;
            Source = XedWfOps.SourceArchive(Config.SourceRoot);
            Stage = XedStageArchive.Create(Config.ExtractRoot);
            Target = TableArchive.create(Config.PubRoot);
            Wf.Created(typeof(XedEtlWf));
        }

        public void Dispose()
        {
            Wf.Disposed(typeof(XedEtlWf));
        }

        public XedPattern[] ExtractPatterns()
        {
            var step = Flow.step(typeof(XedEtlWf));
            var patterns = list<XedPattern>();
            var parser = XedSourceParser.Service;
            var files = @readonly(Source.InstructionFiles);
            try
            {
                for(var i=0; i< files.Length; i++)
                {
                    ref readonly var file = ref skip(files,i);
                    var id = Wf.Raise(new ParsingXedInstructions(ParseInstructionsStep.StepId, file, Wf.Ct));
                    var parsed = span(parser.ParseInstructions(file));
                    for(var j = 0; j< parsed.Length; j++)
                    {
                        ref readonly var p = ref skip(parsed,j);
                        patterns.AddRange(p.Patterns);
                        Stage.Deposit(parsed, file.FileName);
                    }

                    Wf.Raise(new ParsedXedInstructions(step, FS.path(file.Name), parsed.Length, Wf.Ct));
                }
            }
            catch(Exception e)
            {
                term.error(e);
            }

            return patterns.ToArray();
        }

        public XedRuleSet[] ExtractRules()
        {
            var functions = list<XedRuleSet>();
            var parser = XedSourceParser.Service;
            foreach(var file in Source.FunctionFiles)
            {
                var parsed = parser.ParseFunctions(file);
                if(parsed.Length != 0)
                {
                    functions.AddRange(parsed);
                    Stage.Deposit(parsed, file.FileName);
                }
            }
            return functions.ToArray();
        }

        public XedPatternRow[] Emit(XedPattern[] src)
        {
            var sorted = (src as IEnumerable<XedPattern>).OrderBy(x => x.Class).ThenBy(x => x.Category).ThenBy(x => x.Extension).ThenBy(x => x.IsaSet).Array();
            var records = sorted.Map(p => XedWfOps.summary(p));

            Target.Deposit<F,R>(records, Config.SummaryFile);
            return records;
        }

        XedPatternRow[] Filter(XedPatternRow[] src, xed_ext match)
            => src.Where(p => p.Extension  == XedConst.Name(match)).ToArray();

        XedPatternRow[] Filter(XedPatternRow[] src, xed_cat match)
            => src.Where(p => p.Category == XedConst.Name(match)).ToArray();

        void SaveExtensions(XedPatternRow[] src)
        {
            foreach(var selected in Config.Extensions)
                Target.Deposit<F,R>(Filter(src, selected),
                    Config.ExtensionFolder, FS.file(XedConst.Name(selected), Config.DataFileExt));
        }

        void SaveCategories(XedPatternRow[] src)
        {
            foreach(var selected in Config.Categories)
                Target.Deposit<F,R>(Filter(src, selected),
                    Config.CategoryFolder,
                    FS.file(XedConst.Name(selected), Config.DataFileExt)
                    );
        }

        void SaveMnemonics(XedPatternRow[] src)
        {
            var upper = src.Select(s => s.Class).Distinct().OrderBy(x => x).ToArray();
            var dst = Target.Root + FS.file("mnemonics.csv");
            dst.Overwrite(upper);
        }

        const string RuleFormatPattern = "{0,-80} | {1, -12} | {2}";

        const string RulePageBreak = RP.PageBreak120;

        [Op]
        void EmitRules()
        {
            var functions = list<XedRuleSet>();
            var parser = XedSourceParser.Service;
            var paths = @readonly(Source.FunctionFiles);
            var count = paths.Length;
            for(var i=0; i< count; i++)
            {
                ref readonly var path = ref skip(paths,i);
                var rules = parser.ParseFunctions(path);
                var jCount = rules.Length;
                if(jCount != 0)
                {
                    Stage.Deposit(rules, path.FileName);

                    var view = @readonly(rules);
                    for(var j=0; j<jCount; j++)
                    {
                        ref readonly var ruleset = ref skip(view,j);
                        var content = @readonly(ruleset.Terms);
                        var kCount = content.Length;
                        if(kCount != 0)
                        {
                            var target = Target.Table(ruleset.TargetFile);
                            using var writer = target.Writer();
                            writer.WriteLine(ruleset.Description);
                            writer.WriteLine(RulePageBreak);
                            writer.WriteLine(text.format(RuleFormatPattern, "Source", "Operator", "Target"));
                            for(var k=0; k<kCount; k++)
                            {
                                var line = skip(content,k).Format();
                                if(line.Contains('|'))
                                {
                                    var parts = line.SplitClean('|');
                                    if(parts.Length == 2)
                                        writer.WriteLine(text.format(RuleFormatPattern, parts[0], ":=", parts[1]));

                                }
                                else if(line.Contains("->"))
                                {
                                    var parts = line.SplitClean("->");
                                    if(parts.Length == 2)
                                        writer.WriteLine(text.format(RuleFormatPattern, parts[0], "->", parts[1]));
                                }
                                else
                                    writer.WriteLine(line);
                            }

                            Wf.Raise(new EmittedRuleSet(typeof(XedEtlWf), kCount, target, Wf.Ct));
                        }
                    }
                }
            }
        }

        public void Run()
        {
            Target.Clear();

            var patterns = ExtractPatterns();
            var summaries = Emit(patterns);

            if(Settings.EmitExtensions)
            {
                Target.Clear(Config.ExtensionFolder);
                SaveExtensions(summaries);
            }

            if(Settings.EmitCatagories)
            {
                Target.Clear(Config.CategoryFolder);
                SaveCategories(summaries);
            }

            if(Settings.EmitMnemonicList)
                SaveMnemonics(summaries);

            if(Settings.EmitRules)
                EmitRules();
        }
    }
}