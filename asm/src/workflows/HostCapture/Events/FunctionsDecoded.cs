//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class HostCaptureWorkflow
    {
        public readonly struct FunctionsDecoded : IAppEvent<FunctionsDecoded, AsmFunction[]>
        {
            public static FunctionsDecoded Empty => new FunctionsDecoded(ApiHostUri.Empty, new AsmFunction[]{});

            [MethodImpl(Inline)]
            public FunctionsDecoded(ApiHostUri host, AsmFunction[] functions)
            {
                this.Host = host;
                this.Payload = functions;
            }
            
            public ApiHostUri Host {get;}
            
            public AsmFunction[] Payload {get;}

            public string Description
                => $"{Payload.Length} {Host} functions decoded";
            
            public string Format()
                => Description;         
        }    
    }
}