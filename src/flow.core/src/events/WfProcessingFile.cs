//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static Render;
    using static RenderPatterns;
    using static z;

    [Event]
    public readonly struct WfProcessingFile<T> : IWfEvent<WfProcessingFile<T>>
    {
        public const string EventName = nameof(WfProcessingFile<T>);

        public WfEventId EventId {get;}
                        
        public string ActorName {get;}

        public T FileKind {get;}

        public FilePath SourcePath {get;}
                
        public MessageFlair Flair {get;}
        
        [MethodImpl(Inline)]
        public WfProcessingFile(string worker, T kind, FilePath src, CorrelationToken ct, MessageFlair flair = Running)
        {
            EventId = evid(EventName, ct);
            ActorName = worker;
            SourcePath = src;            
            FileKind = kind;
            Flair = flair;        
        }
        
        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName, SourcePath);          
    }   
}