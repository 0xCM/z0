//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using E = AnalyzingExtractReport;

    public readonly struct AnalyzingExtractReport : IAppEvent<E, FilePath>
    {        
        public static E Empty => Define(FilePath.Empty);
        
        [MethodImpl(Inline)]
        public static E Define(FilePath src)
            => new E(src);

        [MethodImpl(Inline)]
        AnalyzingExtractReport(FilePath src)
        {
            this.Payload = src;
        }

        public FilePath Payload {get;}

        public string Description 
            => $"Analyzing extract report {Payload}";

        public E Zero => Empty;
    }
}