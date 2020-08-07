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

    [Event]
    public readonly struct ParsedAsmFile : IWfEvent<ParsedAsmFile>
    {
        const string Pattern = PSx4;
        
        public WfEventId EventId {get;}

        public string ActorName {get;}

        public FilePath SourcePath {get;}

        public uint LineCount {get;}        

        [MethodImpl(Inline)]
        public ParsedAsmFile(string worker, uint lines, FilePath src, CorrelationToken ct)
        {
            EventId = WfEventId.define(nameof(ParsedAsmFile), ct);
            ActorName = worker;
            LineCount = lines;
            SourcePath = src;
        }

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;                                 
        
        [MethodImpl(Inline)]        
        public string Format()
            => text.format(Pattern, EventId, ActorName, LineCount, SourcePath);               
    }        
}