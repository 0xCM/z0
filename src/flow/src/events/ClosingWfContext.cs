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

    [Event(true)]
    public readonly struct ClosingWfContextEvent
    {
        public const string EventName = nameof(ClosingWfContext);
    }
    
    [Event]
    public readonly struct ClosingWfContext : IWfEvent<ClosingWfContext>
    {
        const string Pattern = IdMarker + "Closing workflow context {1}";
        
        public WfEventId Id {get;}

        public readonly Type ContextType;

        [MethodImpl(Inline)]
        public ClosingWfContext(Type type, CorrelationToken? ct = null)
        {
            ContextType = type;
            Id = wfid(nameof(ClosingWfContext), ct);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, ContextType.Name);        
    }
}