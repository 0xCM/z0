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
    public readonly struct OpeningWfContext : IWfEvent<OpeningWfContext>
    {
        const string Pattern = IdMarker + "Opening workflow context {1}";
        
        public WfEventId Id {get;}

        public readonly Type ContextType;

        [MethodImpl(Inline)]
        public OpeningWfContext(Type type, CorrelationToken? ct = null)
        {
            ContextType = type;
            Id = wfid(nameof(OpeningWfContext), ct);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, ContextType.Name);        
    }
}