//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct ParsedAsmFile : IWfEvent<ParsedAsmFile>
    {
        const string Pattern = PSx4;
        
        public WfEventId Id {get;}

        public string WorkerName {get;}

        public FilePath SourcePath {get;}

        public uint LineCount {get;}        

        [MethodImpl(Inline)]
        public ParsedAsmFile(string worker, uint lines, FilePath src, CorrelationToken ct)
        {
            Id = WfEventId.define(nameof(ParsedAsmFile), ct);
            WorkerName = worker;
            LineCount = lines;
            SourcePath = src;
        }

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;                                 
        
        [MethodImpl(Inline)]        
        public string Format()
            => text.format(Pattern, Id, WorkerName, LineCount, SourcePath);               
    }        
}