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
        public readonly struct AsmHexSaved : IAppEvent<AsmHexSaved, AsmOpData[]>
        {
            public static AsmHexSaved Empty => new AsmHexSaved(ApiHostUri.Empty, new AsmOpData[]{}, FilePath.Empty);

            [MethodImpl(Inline)]
            public static AsmHexSaved Define(ApiHostUri host, AsmOpData[] code, FilePath dst)
                => new AsmHexSaved(host,code,dst);
            
            [MethodImpl(Inline)]
            AsmHexSaved(ApiHostUri host, AsmOpData[] code, FilePath dst)
            {
                this.Host = host;
                this.EventData = code;
                this.Target = dst;
            }
            
            public ApiHostUri Host {get;}
            
            public AsmOpData[] EventData {get;}

            public FilePath Target {get;}

            public string Description
                => $"{EventData.Length} {Host} functions saved to {Target}";
            
            public string Format()
                => Description;         
        }    
    }
}