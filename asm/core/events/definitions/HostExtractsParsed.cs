//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using E = AsmEvents.HostExtractsParsed;

    partial class AsmEvents
    {
        public readonly struct HostExtractsParsed : IAppEvent<E, ParsedExtract[]>
        {
            public static E Empty => new E(ApiHostUri.Empty, new ParsedExtract[]{});

            [MethodImpl(Inline)]
            public static E Define(ApiHostUri host, ParsedExtract[] extracts)
                => new E(host,extracts);
            
            [MethodImpl(Inline)]
            public HostExtractsParsed(ApiHostUri host, ParsedExtract[] functions)
            {
                this.Host = host;
                this.Payload = functions;
            }
            
            public ApiHostUri Host {get;}
            
            public ParsedExtract[] Payload {get;}

            public string Description
                => $"{Payload.Length} {Host} members parsed";
            
            public E Zero => Empty;
        }    
    }
}