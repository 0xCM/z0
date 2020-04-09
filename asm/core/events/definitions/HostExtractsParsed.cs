//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct HostExtractsParsed : IAppEvent<HostExtractsParsed, ParsedExtract[]>
    {
        public static HostExtractsParsed Empty => new HostExtractsParsed(ApiHostUri.Empty, new ParsedExtract[]{});

        [MethodImpl(Inline)]
        public static HostExtractsParsed Define(ApiHostUri host, ParsedExtract[] extracts)
            => new HostExtractsParsed(host,extracts);
        
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
        
        public string Format()
            => Description;         
    }    

}