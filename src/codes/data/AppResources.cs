//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;


    class ResourceNames
    {
        public static FileName OpCodeSpecs 
            => FileName.Define(nameof(OpCodeSpecs), FileExtensions.Csv);
    }

    public class AppResources
    {
        static ResExtractor Extractor 
            => ResExtractor.Service();

        public static Option<AppResourceDoc> OpCodeSpecs 
            => Extractor.ExtractDocument(ResourceNames.OpCodeSpecs);
    }
}