//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AnalyzingExtractReport : IAppEvent<AnalyzingExtractReport, FilePath>
    {        
        public static AnalyzingExtractReport Empty => Define(FilePath.Empty);
        
        [MethodImpl(Inline)]
        public static AnalyzingExtractReport Define(FilePath src)
            => new AnalyzingExtractReport(src);

        [MethodImpl(Inline)]
        AnalyzingExtractReport(FilePath src)
        {
            this.SourcePath = src;
        }

        public readonly FilePath SourcePath;

        public string Description 
            => $"Analyzing extract report {SourcePath}";

        public FilePath Payload 
            => SourcePath;

        public string Format() 
            => Description;

        public override string ToString() 
            => Format();    
    }
}