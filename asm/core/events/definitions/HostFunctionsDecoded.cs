//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct HostFunctionsDecoded : IAppEvent<HostFunctionsDecoded, AsmFunction[]>
    {
        public static HostFunctionsDecoded Empty => new HostFunctionsDecoded(ApiHostUri.Empty, new AsmFunction[]{});

        [MethodImpl(Inline)]
        public static HostFunctionsDecoded Define(ApiHostUri host, AsmFunction[] functions)
            => new HostFunctionsDecoded(host,functions);

        [MethodImpl(Inline)]
        HostFunctionsDecoded(ApiHostUri host, AsmFunction[] functions)
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