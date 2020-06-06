//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    [ApiHost("api")]
    public readonly struct AsmD : IApiHost<AsmD>
    {              
        public static AsmD Service => default;
        
        public IEnumerable<FileName> ResourceNames
            => Extractor.ResourceNames.Select(x => FileName.Define(x));   

        public Option<AppResourceDoc> ResDoc(FileName name)     
            => Extractor.ExtractDocument(name);

        public Option<string[]> ResText(string name)     
            => Extractor.ExtractTextLines(name);
        
        public string[] OpCodeSpecText
            => ResText(OpCodeSpecName.Name).Require();

        public AppResourceDoc OpCodeSpecDoc
            => ResDoc(OpCodeSpecName).Require();
    
        static ResExtractor Extractor 
            => ResExtractor.Service();    

        static FileName OpCodeSpecName 
            => FileName.Define("OpCodeSpecs", FileExtensions.Csv);
    }
}