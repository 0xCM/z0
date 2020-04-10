//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using E = AsmEvents.HostCodeSaved;

    partial class AsmEvents
    {
        public readonly struct HostCodeSaved : IAppEvent<E, AsmCode[]>
        {
            public static E Empty => new E(ApiHostUri.Empty, new AsmCode[]{}, FilePath.Empty);

            [MethodImpl(Inline)]
            public static E Define(ApiHostUri host, AsmCode[] code, FilePath dst)
                => new E(host,code,dst);
            
            [MethodImpl(Inline)]
            HostCodeSaved(ApiHostUri host, AsmCode[] code, FilePath dst)
            {
                this.Host = host;
                this.Payload = code;
                this.Target = dst;
            }
            
            public ApiHostUri Host {get;}
            
            public AsmCode[] Payload {get;}

            public FilePath Target {get;}

            public string Description
                => $"{Payload.Length} {Host} functions saved to {Target}";
                
            public E Zero => Empty;            
        }    
    }
}