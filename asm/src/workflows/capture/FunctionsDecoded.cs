//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    partial class HostCaptureWorkflow
    {
        public readonly struct FunctionsDecoded : IAppEvent<FunctionsDecoded, AsmFunction[]>
        {
            public static FunctionsDecoded Empty => new FunctionsDecoded(ApiHostUri.Empty, new AsmFunction[]{});

            public FunctionsDecoded(ApiHostUri host, AsmFunction[] functions)
            {
                this.Host = host;
                this.EventData = functions;
            }
            
            public ApiHostUri Host {get;}
            
            public AsmFunction[] EventData {get;}

            public string EventName
                => $"{Host} functions decoded: {EventData.Length}";
            
            public string Format()
                => EventName;         
        }    

    }


}