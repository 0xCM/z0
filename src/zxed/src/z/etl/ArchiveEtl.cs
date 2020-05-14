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

    public readonly struct ArchiveEtl
    {
        public static ArchiveEtl Service(IAppContext context)
            => new ArchiveEtl(context);

        public FolderPath ArchiveRoot {get;}

        readonly IContext Context;
        
        readonly SourceArchive Src;

        readonly ExtractArchive Dst;

        readonly IPublicArchive Pub;

        public ArchiveEtl(IAppContext context)
        {
            Context = context;
            ArchiveRoot = context.AppPaths.AppSrcPath + FolderName.Define("data");;
            Src = SourceArchive.Create(ArchiveRoot + FolderName.Define("source"));
            Dst = ExtractArchive.Create(ArchiveRoot + FolderName.Define("extracts"));
            Pub = PublicArchive.Service(ArchiveRoot + FolderName.Define("datasets"));            
        }

        public InstructionPattern[] ExtractPatterns()
        {
            var patterns = list<InstructionPattern>();
            var parser = FileParser.Service;

            foreach(var f in Src.InstructionFiles)
            {
                var parsed = parser.ParseInstructions(f);
                var count = parsed.Sum(x => x.Patterns.Length);
                Control.iter(parsed, p => patterns.AddRange(p.Patterns));
                Dst.Deposit(parsed, f.FileName);
            }
            return patterns.ToArray();
        }

        public PatternSummary[] PublishSummary(InstructionPattern[] src)

        {
            var sorted = src.OrderBy(x => x.Class).ThenBy(x => x.Category).ThenBy(x => x.Extension).ThenBy(x => x.IsaSet).ToArray();                        
            var records = sorted.Map(p => p.Summary());
            Pub.Deposit(records, FileName.Define("summary", FileExtensions.Csv));
            return records;
        }

        xed_ext[] Extensions => new xed_ext[]{
            xed_ext.XED_EXTENSION_BASE,             
            xed_ext.XED_EXTENSION_AVX, 
            xed_ext.XED_EXTENSION_AVX2,            
            xed_ext.XED_EXTENSION_BMI1,            
            xed_ext.XED_EXTENSION_BMI2,            
            xed_ext.XED_EXTENSION_SSE,            
            xed_ext.XED_EXTENSION_SSE2,            
        };

        xed_cat[] Categories => new xed_cat[]{
            xed_cat.XED_CATEGORY_BINARY,
            xed_cat.XED_CATEGORY_SHIFT,
            xed_cat.XED_CATEGORY_BITBYTE,
            xed_cat.XED_CATEGORY_COND_BR,
            xed_cat.XED_CATEGORY_UNCOND_BR,
            xed_cat.XED_CATEGORY_LOGICAL,
        };

        static FileExtension DefaultFileExt => FileExtensions.Csv;

        PatternSummary[] Filter(PatternSummary[] summaries, xed_ext match)
            => summaries.Where(p => p.Extension == XedConst.Name(match)).ToArray();

        PatternSummary[] Filter(PatternSummary[] summaries, xed_cat match)
            => summaries.Where(p => p.Category == XedConst.Name(match)).ToArray();

        void PublishExtensions(PatternSummary[] summaries)
        {                        
            foreach(var selected in Extensions)
                Pub.Deposit(Filter(summaries, selected), 
                    ExtensionsFolder, 
                    FileName.Define(XedConst.Name(selected), DefaultFileExt)
                    );
        }

        void PublishCategories(PatternSummary[] summaries)
        {
            foreach(var selected in Categories)
                Pub.Deposit(Filter(summaries, selected), 
                    CategoriesFolder, 
                    FileName.Define(XedConst.Name(selected), DefaultFileExt)
                    );

        }

        FolderName ExtensionsFolder => FolderName.Define("extensions");

        FolderName CategoriesFolder => FolderName.Define("categories");

        public void Run()
        {                        
            Pub.Clear();
            Pub.Clear(ExtensionsFolder);
            Pub.Clear(CategoriesFolder);
            
            var patterns = ExtractPatterns();
            var summaries = PublishSummary(patterns);                        

            PublishExtensions(summaries);
            PublishCategories(summaries);

        }
    }
}