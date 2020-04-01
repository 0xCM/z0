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
        public readonly struct ExtractsParsed : IAppEvent<ExtractsParsed, ParsedExtract[]>
        {
            public static ExtractsParsed Empty => new ExtractsParsed(ApiHostUri.Empty, new ParsedExtract[]{});

            [MethodImpl(Inline)]
            public ExtractsParsed(ApiHostUri host, ParsedExtract[] functions)
            {
                this.Host = host;
                this.EventData = functions;
            }
            
            public ApiHostUri Host {get;}
            
            public ParsedExtract[] EventData {get;}

            public string Description
                => $"{EventData.Length} {Host} members parsed";
            
            public string Format()
                => Description;         
        }    
    }
}