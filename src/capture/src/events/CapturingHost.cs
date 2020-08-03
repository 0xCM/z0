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

    public readonly struct CapturingHost : IWfEvent<CapturingHost>
    {            
        const string Pattern = "";

        public WfEventId Id  => WfEventId.define("Placeholder");

        public readonly ApiHostUri Host;

        [MethodImpl(Inline)]
        public CapturingHost(ApiHostUri host)
            => Host = host;

        public string Format() 
            => $"{Host.Format()} host capture step starting";

        public CapturingHost Zero
            => Empty;
        
        public static CapturingHost Empty 
            => new CapturingHost(ApiHostUri.Empty);
    }    
}