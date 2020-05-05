//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using E = CaptureWorkflowEvents.HexSaved;

    partial class CaptureWorkflowEvents
    {
        public readonly struct HexSaved : IAppEvent<E>
        {
            public static E Empty => new E(ApiHostUri.Empty, new UriHex[]{}, FilePath.Empty);

            [MethodImpl(Inline)]
            public static E Define(ApiHostUri host, UriHex[] code, FilePath dst)
                => new E(host,code,dst);
            
            [MethodImpl(Inline)]
            HexSaved(ApiHostUri host, UriHex[] code, FilePath dst)
            {
                this.Host = host;
                this.Payload = code;
                this.Target = dst;
            }
            
            public ApiHostUri Host {get;}
            
            public UriHex[] Payload {get;}

            public FilePath Target {get;}

            public string Description
                => $"{Payload.Length} {Host} functions saved to {Target}";
            
            public E Zero => Empty;            

            public AppMsgColor Flair => AppMsgColor.Cyan;
        }    
    }
}