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
    using static EmittedHostBytesEvent;

    public readonly struct EmittedHostBytesEvent
    {
        public const string EventName = nameof(EmittedHostBytes);

        public const string Pattern = IdMarker + "Emitted {1} x86 code accessors for {2} api";
    }
    
    public readonly struct EmittedHostBytes : IWfEvent<EmittedHostBytes>
    {
        public WfEventId Id {get;}

        public readonly ApiHostUri Host;

        public readonly ushort AccessorCount;

        [MethodImpl(Inline)]
        public EmittedHostBytes(ApiHostUri host, ushort count, CorrelationToken ct)
        {
            Id = wfid(nameof(EmittedHostBytes), ct);
            Host= host;
            AccessorCount = count;
        }        
        
        public string Format()
            => text.format(Pattern, Id, AccessorCount, Host.Format());        
    }
}