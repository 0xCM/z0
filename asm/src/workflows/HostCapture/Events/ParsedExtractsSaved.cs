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
        public readonly struct AsmHexSaved : IAppEvent<AsmHexSaved, AsmOpBits[]>
        {
            public static AsmHexSaved Empty => new AsmHexSaved(ApiHostUri.Empty, new AsmOpBits[]{}, FilePath.Empty);

            [MethodImpl(Inline)]
            public static AsmHexSaved Define(ApiHostUri host, AsmOpBits[] code, FilePath dst)
                => new AsmHexSaved(host,code,dst);
            
            [MethodImpl(Inline)]
            AsmHexSaved(ApiHostUri host, AsmOpBits[] code, FilePath dst)
            {
                this.Host = host;
                this.Payload = code;
                this.Target = dst;
            }
            
            public ApiHostUri Host {get;}
            
            public AsmOpBits[] Payload {get;}

            public FilePath Target {get;}

            public string Description
                => $"{Payload.Length} {Host} functions saved to {Target}";
            
            public string Format()
                => Description;         
        }    
    }
}