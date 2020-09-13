//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Xed;

    using static z;
    using static Konst;

    using xed_ext = Xed.xed_extension_enum_t;
    using xed_cat = Xed.xed_category_enum_t;

    using F = XedPatternField;
    using R = XedPatternSummary;
    using static RenderPatterns;

    [ApiHost]
    public readonly ref struct XedWf
    {
        readonly XedEtlConfig Config;

        readonly IWfShell Wf;

        readonly XedSourceArchive Src;

        readonly XedStagingArchive Dst;

        readonly TableArchive Pub;

        readonly CorrelationToken Ct;

        public XedWf(IWfShell context, XedEtlConfig config)
        {
            Wf = context;
            Config = config;
            Ct = Wf.Ct;
            Src = XedSourceArchive.Create(Config.SourceRoot);
            Dst = XedStagingArchive.Create(Config.ExtractRoot);
            Pub = TableArchive.create(Config.PubRoot);
            Wf.Created(typeof(XedWf));
        }

        public void Dispose()
        {
            Wf.Disposed(typeof(XedWf));
        }

        public XedPattern[] ExtractPatterns()
        {
            var step = Flow.step(typeof(void),typeof(XedWf));
            var patterns = list<XedPattern>();
            var parser = XedSourceParser.Service;
            var files = Src.InstructionFiles.ToSpan();
            try
            {
                for(var i=0; i< files.Length; i++)
                {
                    ref readonly var file = ref skip(files,i);
                    var id = Wf.Raise(new ParsingXedInstructions(ParseInstructionsStep.StepId, file,Ct));
                    var parsed = span(parser.ParseInstructions(file));
                    for(var j = 0; j< parsed.Length; j++)
                    {
                        ref readonly var p = ref skip(parsed,j);
                        patterns.AddRange(p.Patterns);
                        Dst.Deposit(parsed, file.FileName);
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

        public XedFunctionData[] ExtractFunctions()
        {
            var functions = list<XedFunctionData>();
            var parser = XedSourceParser.Service;
            foreach(var file in Src.FunctionFiles)
            {
                var parsed = parser.ParseFunctions(file);
                if(parsed.Length != 0)
                {
                    functions.AddRange(parsed);
                    Dst.Deposit(parsed, file.FileName);
                }
            }
            return functions.ToArray();
        }

        public XedPatternSummary[] PublishSummary(XedPattern[] src)
        {
            var sorted = (src as IEnumerable<XedPattern>).OrderBy(x => x.Class).ThenBy(x => x.Category).ThenBy(x => x.Extension).ThenBy(x => x.IsaSet).Array();
            var records = sorted.Map(p => XedOps.summary(p));
            Pub.Deposit<F,R>(records, FileName.define("summary", FileExtensions.Csv));
            return records;
        }

        XedPatternSummary[] Filter(XedPatternSummary[] src, xed_ext match)
            => src.Where(p => p.Extension == Xed.XedConst.Name(match)).ToArray();

        XedPatternSummary[] Filter(XedPatternSummary[] src, xed_cat match)
            => src.Where(p => p.Category == Xed.XedConst.Name(match)).ToArray();

        void SaveExtensions(XedPatternSummary[] src)
        {
            foreach(var selected in Config.Extensions)
                Pub.Deposit<F,R>(Filter(src, selected),
                    Config.ExtensionFolder, FS.file(Xed.XedConst.Name(selected), Config.DataFileExt));
        }

        void SaveCategories(XedPatternSummary[] src)
        {
            foreach(var selected in Config.Categories)
                Pub.Deposit<F,R>(Filter(src, selected),
                    Config.CategoryFolder,
                    FileName.define(Xed.XedConst.Name(selected), Config.DataFileExt)
                    );
        }

        void SaveMnemonics(XedPatternSummary[] src)
        {
            var upper = src.Select(s => s.Class).Distinct().OrderBy(x => x).ToArray();
            var dst = Pub.ArchiveRoot + FileName.define("mnemonics.csv");
            dst.Overwrite(upper);
        }

        void SaveFunctions(XedFunctionData[] src)
        {
            var path = Pub.ArchiveRoot + FileName.define("rules.txt");
            using var writer = path.Writer();
            for(var i=0; i<src.Length; i++)
            {
                    ref readonly var f = ref src[i];
                    var body = f.Body;
                    if(body.Length != 0)
                    {
                        writer.WriteLine(f.Declaration);
                        writer.WriteLine(PageBreak);

                        for(var j = 0; j < body.Length; j++)
                            writer.WriteLine(body[j]);

                        if(i != src.Length - 1)
                            writer.WriteLine();
                    }
            }
        }

        public void Run()
        {
            Pub.Clear();
            Pub.Clear(Config.ExtensionFolder);
            Pub.Clear(Config.CategoryFolder);

            var patterns = ExtractPatterns();
            var summaries = PublishSummary(patterns);
            var functions = ExtractFunctions();

            SaveExtensions(summaries);
            SaveCategories(summaries);
            SaveMnemonics(summaries);
            SaveFunctions(functions);
        }

        const string PageBreak = PageBreak120;
    }
}