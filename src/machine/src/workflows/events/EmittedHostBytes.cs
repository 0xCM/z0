//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EmittedHostBytes : IWorkflowEvent<EmittedHostBytes>
    {
        const string Pattern = "{0}: Emitted {1} x86 code accessors for {2} api";

        public readonly WfEventId Id;

        public readonly ApiHostUri Host;

        public readonly ushort AccessorCount;

        [MethodImpl(Inline)]
        public EmittedHostBytes(ApiHostUri host, ushort count, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(nameof(EmittedHostBytes), ct ?? CorrelationToken.create(), z.now());
            Host= host;
            AccessorCount = count;
        }        
        
        public string Format()
            => text.format(Pattern, Id, AccessorCount, Host.Format());

        public string Description
            => Format();
        
        public override string ToString()
            => Format();
    }
}