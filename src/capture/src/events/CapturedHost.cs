//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct CapturedHost : IWfEvent<CapturedHost>
    {            
        const string Pattern = "";

        public WfEventId Id  => WfEventId.define("Placeholder");

        public readonly ApiHostUri Host;

        [MethodImpl(Inline)]
        public CapturedHost(ApiHostUri host, CorrelationToken? ct = null)
            => Host = host;

        public string Format() 
            => $"{Host.Format()} host capture step completed";
    }    
}