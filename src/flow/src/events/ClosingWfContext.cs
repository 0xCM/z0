//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ClosingWfContext : IWfEvent<ClosingWfContext>
    {
        const string Pattern = "{0}: Closing workflow context {1}";
        
        public WfEventId Id {get;}

        public readonly Type ContextType;

        [MethodImpl(Inline)]
        public ClosingWfContext(Type type, CorrelationToken? ct = null)
        {
            ContextType = type;
            Id = WfEventId.define(nameof(ClosingWfContext), ct);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, ContextType.Name);        
    }
}