//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;
    using static Konst;

    using xed_ext = xed_extension_enum_t;
    using xed_cat = xed_category_enum_t;


    using F = PatternField;
    using R = PatternSummary;

    public readonly struct EtlWorkflow
    {
        public static EtlWorkflow Service(IAppContext context)
            => new EtlWorkflow(context);

        public FolderPath SourceRoot {get;}

        readonly AsmArchiveConfig Config;

        readonly IContext Context;
        
        readonly SourceArchive Src;

        readonly StagingArchive Dst;

        readonly ITableArchive Pub;

        readonly FolderPath TargetRoot;
        
        public EtlWorkflow(IAppContext context)
        {
            Context = context;
            Config = default(AsmArchiveConfig);
            SourceRoot = Config.SourceRoot;
            TargetRoot = Config.TargetRoot;
            Src = SourceArchive.Create(SourceRoot);            
            Dst = StagingArchive.Create(Config.StageRoot);
            Pub = TableArchive.Service(Config.PublicationRoot);            
        }

        public InstructionPattern[] ExtractPatterns()
        {
            var patterns = list<InstructionPattern>();
            var parser = SourceParser.Service;
            var files = Src.InstructionFiles.ToSpan();
            try
            {
                for(var i=0; i< files.Length; i++)
                {
                    ref readonly var file = ref skip(files,i);
                    term.magenta($"Parsing instructions", file);
                    var parsed = span(parser.ParseInstructions(file));
                    for(var j = 0; j< parsed.Length; j++)
                    {
                        ref readonly var p = ref skip(parsed,j);
                        patterns.AddRange(p.Patterns);
                        Dst.Deposit(parsed, file.FileName);
                    }
                }
            }
            catch(Exception e)
            {
                term.error(e);
            }

            return patterns.ToArray();
        }
        
        static InstructionRecord[] InstructionRecords(InstructionPattern[] src)
        {
            var input = Root.@readonly(src);
            var count = input.Length;
            var dst = Root.alloc<InstructionRecord>(count);
            var target = Root.span(dst);
            for(var i=0; i<count; i++)
            {
                ref readonly var x = ref skip(input,i);
                seek(target,i) = new InstructionRecord(
                    Sequence: i, 
                    Mnemonic: x.Class, 
                    Extension: x.Extension, 
                    BaseCode: x.BaseCodeText(), 
                    Mod: default,
                    Reg: default);                
            }
            return dst;
        }

        public FunctionData[] ExtractFunctions()
        {
            var functions = Root.list<FunctionData>();
            var parser = SourceParser.Service;
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

        public PatternSummary[] PublishSummary(InstructionPattern[] src)

        {
            var sorted = src.OrderBy(x => x.Class).ThenBy(x => x.Category).ThenBy(x => x.Extension).ThenBy(x => x.IsaSet).ToArray();                        
            var records = sorted.Map(p => p.Summary());
            Pub.Deposit<F,R>(records, FileName.Define("summary", FileExtensions.Csv));
            return records;
        }

        PatternSummary[] Filter(PatternSummary[] src, xed_ext match)
            => src.Where(p => p.Extension == XedConst.Name(match)).ToArray();

        PatternSummary[] Filter(PatternSummary[] src, xed_cat match)
            => src.Where(p => p.Category == XedConst.Name(match)).ToArray();

        void SaveExtensions(PatternSummary[] src)
        {                        
            foreach(var selected in Config.Extensions)
                Pub.Deposit<F,R>(Filter(src, selected), 
                    Config.ExtensionFolder, 
                    FileName.Define(XedConst.Name(selected), Config.DataFileExt)
                    );
        }

        void SaveCategories(PatternSummary[] src)
        {
            foreach(var selected in Config.Categories)
                Pub.Deposit<F,R>(Filter(src, selected), 
                    Config.CategoryFolder, 
                    FileName.Define(XedConst.Name(selected), Config.DataFileExt)
                    );
        }

        void SaveMnemonics(PatternSummary[] src)
        {
            var upper = src.Select(s => s.Class).Distinct().OrderBy(x => x).ToArray();
            var dst = Pub.ArchiveRoot + FileName.Define("mnemonics.csv");
            dst.Ovewrite(upper);
        }

        void SaveFunctions(FunctionData[] src)
        {
            var path = Pub.ArchiveRoot + FileName.Define("rules.txt");
            using var writer = path.Writer();
            for(var i=0; i<src.Length; i++)
            {
                    ref readonly var f = ref src[i];
                    var body = f.Body;
                    if(body.Length != 0)
                    {
                        writer.WriteLine(f.Declaration);
                        writer.WriteLine(HSep120);

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

            // SaveExtensions(summaries);
            // SaveCategories(summaries);
            // SaveMnemonics(summaries);
            SaveFunctions(functions);
        }

        const string HSep120 = "--------------------------------------------------------------------------------------------------------";
    }
}