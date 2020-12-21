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

    using static z;

    using Z0.Xed;
    using xed_ext = Xed.xed_extension_enum_t;
    using xed_cat = Xed.xed_category_enum_t;

    using F = XedPatternField;
    using R = XedPatternRow;

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
            //Stage = XedStage.Create(db.TmpDir(Subject));
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
                    Wf.ProcessingFile(file, kind);
                    var parsed = span(parser.ParseInstructions(file));
                    for(var j = 0; j< parsed.Length; j++)
                    {
                        ref readonly var p = ref skip(parsed,j);
                        patterns.AddRange(p.Patterns);
                        Save(parsed, file.FileName);
                    }

                    Wf.ProcessedFile(FS.path(file.Name), kind, parsed.Length);
                }
            }
            catch(Exception e)
            {
                term.error(e);
            }

            return patterns.ToArray();
        }

        public FS.FolderName InstructionFolder
            => FS.folder("instructions");

        public FS.FolderName FunctionFolder
            => FS.folder("functions");

        public FS.FolderPath InstructionDir
            => Root + InstructionFolder;

        public FS.FolderPath FunctionDir
            => Root + FunctionFolder;

        const string HSep = RP.PageBreak120;

        public void Save(ReadOnlySpan<XedInstructionDoc> src, FS.FileName name)
        {
            var path = InstructionDir + name;
            using var writer = path.Writer();
            for(var i=0; i<src.Length; i++)
            {
                var rows = src[i];
                for(var j = 0; j < rows.RowCount; j++)
                    writer.WriteLine(rows[j].Text);
                if(i != src.Length - 1)
                    writer.WriteLine(HSep);
            }
        }

        public void Save(XedRuleSet[] src, FS.FileName name)
        {
            var path = FunctionDir + name;
            using var writer = path.Writer();
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var f = ref src[i];
                var body = f.Terms;
                if(body.Length != 0)
                {
                    writer.WriteLine(f.Description);
                    writer.WriteLine(HSep);

                    for(var j = 0; j < body.Length; j++)
                        writer.WriteLine(body[j]);

                    if(i != src.Length - 1)
                        writer.WriteLine();
                }
            }
        }

        public XedPatternRow[] Emit(XedPattern[] src)
        {
            var sorted = (src as IEnumerable<XedPattern>).OrderBy(x => x.Class).ThenBy(x => x.Category).ThenBy(x => x.Extension).ThenBy(x => x.IsaSet).Array();
            var records = sorted.Map(p => XedWfOps.row(p));

            var id = Config.SummaryFile.WithoutExtension.Name;
            var type = Config.SummaryFile.FileExt;
            var subject = "xed";
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
                Target.Deposit<F,R>(Filter(src, selected), Config.ExtensionFolder, FS.file(XedConst.Name(selected), Config.DataFileExt));
        }

        void SaveCategories(XedPatternRow[] src)
        {
            foreach(var selected in Config.Categories)
            {
                Target.Deposit<F,R>(Filter(src, selected),
                    Config.CategoryFolder,
                    FS.file(XedConst.Name(selected), Config.DataFileExt)
                    );
            }
        }

        void SaveMnemonics(XedPatternRow[] src)
        {
            var upper = src.Select(s => s.Class).Distinct().OrderBy(x => x).ToArray();
            var dst = Target.TablePath(FS.file("mnemonics", FileExtensions.Csv));
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
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(paths,i);
                var rules = parser.ParseFunctions(path);
                var jCount = rules.Length;
                if(jCount != 0)
                {
                    Save(rules, path.FileName);

                    var view = @readonly(rules);
                    for(var j=0; j<jCount; j++)
                    {
                        ref readonly var ruleset = ref skip(view,j);
                        var content = @readonly(ruleset.Terms);
                        var kCount = content.Length;
                        if(kCount != 0)
                        {
                            var target = Target.TablePath(FS.folder("rules"), ruleset.TargetFile);
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

                            Wf.Raise(new EmittedRuleSet(typeof(XedWf), kCount, target, Wf.Ct));
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

            if(Settings.EmitCategories)
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