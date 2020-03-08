//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class HostCaptureWorkflow
    {
        public readonly struct AsmFunctionsDecoded : IAppEvent<AsmFunctionsDecoded, AsmFunction[]>
        {
            public static AsmFunctionsDecoded Empty => new AsmFunctionsDecoded(ApiHostUri.Empty, new AsmFunction[]{});

            public AsmFunctionsDecoded(ApiHostUri host, AsmFunction[] functions)
            {
                this.Host = host;
                this.EventData = functions;
            }
            
            public ApiHostUri Host {get;}
            
            public AsmFunction[] EventData {get;}

            public string Description
                => $"{EventData.Length} {Host} functions decoded";
            
            public string Format()
                => Description;         
        }    
    }
}