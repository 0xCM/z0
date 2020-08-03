//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    using E = AnalyzingExtractReport;

    public readonly struct AnalyzingExtractReport : IWfEvent<E>
    {                    
        const string Pattern = "";

        public WfEventId Id  => WfEventId.define(nameof(AnalyzingExtractReport));

        [MethodImpl(Inline)]
        internal AnalyzingExtractReport(FilePath src)
            => Path = src;

        public FilePath Path {get;}

        public string Format() 
            => $"Analyzing extract report {Path}";

        public E Zero 
            => Empty;

        public static E Empty 
            => new E(FilePath.Empty);
    }
}