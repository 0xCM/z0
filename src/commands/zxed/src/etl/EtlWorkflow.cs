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

    using static Seed;
    using static Memories;

    using static Archives;
    using static Res;

    using xed_ext = xed_extension_enum_t;
    using xed_cat = xed_category_enum_t;

    public readonly struct EtlWorkflow
    {
        public static EtlWorkflow Service(IAppContext context)
            => new EtlWorkflow(context);

        public FolderPath ArchiveRoot {get;}

        readonly ArchiveEtlConfig Config;

        readonly IContext Context;
        
        readonly SourceArchive Src;

        readonly StagingArchive Dst;

        readonly IPublicArchive Pub;

        public EtlWorkflow(IAppContext context)
        {
            Context = context;
            Config = default(ArchiveEtlConfig);
            //ArchiveRoot = context.AppPaths.AppSrcPath + Config.RootFolder;
            ArchiveRoot =  FolderPath.Define(@"J:\dev\projects\z0\src\commands\data");
            Src = SourceArchive.Create(ArchiveRoot + Config.SourceFolder);
            Dst = StagingArchive.Create(ArchiveRoot + Config.StageFolder);
            Pub = PublicArchive.Service(ArchiveRoot + Config.DatasetFolder);            
        }

        public InstructionPattern[] ExtractPatterns()
        {
            var patterns = list<InstructionPattern>();
            var parser = SourceParser.Service;

            foreach(var f in Src.InstructionFiles)
            {
                var parsed = parser.ParseInstructions(f);
                Control.iter(parsed, p => patterns.AddRange(p.Patterns));
                Dst.Deposit(parsed, f.FileName);
            }
            return patterns.ToArray();
        }

        public FunctionData[] ExtractFunctions()
        {
            var functions = list<FunctionData>();
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
            Pub.Deposit(records, FileName.Define("summary", FileExtensions.Csv));
            return records;
        }

        PatternSummary[] Filter(PatternSummary[] src, xed_ext match)
            => src.Where(p => p.Extension == XedConst.Name(match)).ToArray();

        PatternSummary[] Filter(PatternSummary[] src, xed_cat match)
            => src.Where(p => p.Category == XedConst.Name(match)).ToArray();

        void SaveExtensions(PatternSummary[] src)
        {                        
            foreach(var selected in Config.Extensions)
                Pub.Deposit(Filter(src, selected), 
                    Config.ExtensionFolder, 
                    FileName.Define(XedConst.Name(selected), Config.DataFileExt)
                    );
        }

        void SaveCategories(PatternSummary[] src)
        {
            foreach(var selected in Config.Categories)
                Pub.Deposit(Filter(src, selected), 
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

            SaveExtensions(summaries);
            SaveCategories(summaries);
            SaveMnemonics(summaries);
            SaveFunctions(functions);
        }

        const string HSep120 = "--------------------------------------------------------------------------------------------------------";
    }
}