//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using E = ExtractionEvents.AnalyzingExtractReport;

    public partial class ExtractionEvents
    {
        public readonly struct AnalyzingExtractReport : IAppEvent<E>
        {        
            public static E Empty => Define(FilePath.Empty);
            
            [MethodImpl(Inline)]
            public static E Define(FilePath src)
                => new E(src);

            [MethodImpl(Inline)]
            AnalyzingExtractReport(FilePath src)
            {
                this.Path = src;
            }

            public FilePath Path {get;}

            public string Description 
                => $"Analyzing extract report {Path}";

            public E Zero => Empty;
        }

    }

}