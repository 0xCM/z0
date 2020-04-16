//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public partial class ExtractionEvents
    {
        public readonly struct AnalyzingExtractReport : IAppEvent<AnalyzingExtractReport, FilePath>
        {        
            public static AnalyzingExtractReport Empty => Define(FilePath.Empty);
            
            [MethodImpl(Inline)]
            public static AnalyzingExtractReport Define(FilePath src)
                => new AnalyzingExtractReport(src);

            [MethodImpl(Inline)]
            AnalyzingExtractReport(FilePath src)
            {
                this.Payload = src;
            }

            public FilePath Payload {get;}

            public string Description 
                => $"Analyzing extract report {Payload}";

            public AnalyzingExtractReport Zero => Empty;
        }

    }

}