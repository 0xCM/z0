//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static Konst;

    public readonly struct Watching<T> : IWfEvent<Watching<T>>
        where T : ITextual
    {
        public const string EventName = nameof(Watching<T>);

        public const string Message = "{0} | {1} | {2}";
        
        public WfEventId EventId {get;}

        public string ActorName {get;}

        public T Subject {get;}

        [MethodImpl(Inline)]
        public Watching(T subject, CorrelationToken ct, [CallerFilePath] string actor = null)
        {
            EventId = WfEventId.define(EventName, ct);
            ActorName = Path.GetFileNameWithoutExtension(actor);
            Subject = subject;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Message, EventId, ActorName, Subject);
    }
}