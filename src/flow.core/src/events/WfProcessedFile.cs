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
    public readonly struct WfProcessedFile<T> : IWfEvent<WfProcessedFile<T>>
    {
        public const string EventName = nameof(WfProcessedFile<T>);

        public WfEventId EventId {get;}
                        
        public string ActorName {get;}

        public T FileKind {get;}

        public FilePath SourcePath {get;}
                
        public uint ProcessedSize {get;}
        
        public MessageFlair Flair {get;}
        
        [MethodImpl(Inline)]
        public WfProcessedFile(string worker, T kind, FilePath src, uint size, CorrelationToken ct, MessageFlair flair = Ran)
        {
            EventId = evid(EventName, ct);
            ActorName = worker;
            SourcePath = src;            
            FileKind = kind;
            ProcessedSize = size;            
            Flair = flair;        
        }
        
        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx4, EventId, ActorName, ProcessedSize, SourcePath);          
    }   
}