//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CapturedHost : IAppEvent<CapturedHost>
    {            
        public readonly ApiHostUri Host;

        [MethodImpl(Inline)]
        public CapturedHost(ApiHostUri host)
            => Host = host;

        public string Description
            => $"{Host.Format()} host capture step completed";

        public CapturedHost Zero
            => Empty;
        
        public static CapturedHost Empty 
            => new CapturedHost(ApiHostUri.Empty);
    }    
}