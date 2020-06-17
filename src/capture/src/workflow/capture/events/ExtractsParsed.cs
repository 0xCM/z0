//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using E = CaptureWorkflowEvents.ExtractsParsed;

    partial class CaptureWorkflowEvents
    {
        public readonly struct ExtractsParsed : IAppEvent<E>
        {
            public static E Empty => new E(ApiHostUri.Empty, new ParsedMember[]{});

            [MethodImpl(Inline)]
            public static E Define(ApiHostUri host, ParsedMember[] extracts)
                => new E(host,extracts);
            
            [MethodImpl(Inline)]
            public ExtractsParsed(ApiHostUri host, ParsedMember[] functions)
            {
                this.Host = host;
                this.Payload = functions;
            }
            
            public ApiHostUri Host {get;}
            
            public ParsedMember[] Payload {get;}

            public string Description
                => $"{Payload.Length} {Host} members parsed";
            
            public E Zero => Empty;
        }    
    }
}