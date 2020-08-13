//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static FormatPatterns;
    
    public readonly struct ClearedDirectory : IWfEvent<ClearedDirectory>
    {
        public const string EventName = nameof(ClearedDirectory);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public readonly FolderPath Path;

        [MethodImpl(Inline)]
        public ClearedDirectory(string actor, FolderPath path, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, ct);
            ActorName = actor;
            Path = path;
        }
        
        public object Description 
            => new {Path};

        public string Format() 
            => text.format(PSx3, EventId, ActorName, Description);
    }    
}