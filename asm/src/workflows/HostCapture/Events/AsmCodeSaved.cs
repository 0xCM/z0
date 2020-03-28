//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    partial class HostCaptureWorkflow
    {
        public readonly struct AsmCodeSaved : IAppEvent<AsmCodeSaved, AsmCode[]>
        {
            public static AsmCodeSaved Empty => new AsmCodeSaved(ApiHostUri.Empty, new AsmCode[]{}, FilePath.Empty);

            [MethodImpl(Inline)]
            public static AsmCodeSaved Define(ApiHostUri host, AsmCode[] code, FilePath dst)
                => new AsmCodeSaved(host,code,dst);
            
            [MethodImpl(Inline)]
            AsmCodeSaved(ApiHostUri host, AsmCode[] code, FilePath dst)
            {
                this.Host = host;
                this.EventData = code;
                this.Target = dst;
            }
            
            public ApiHostUri Host {get;}
            
            public AsmCode[] EventData {get;}

            public FilePath Target {get;}

            public string Description
                => $"{EventData.Length} {Host} functions saved to {Target}";
            
            public string Format()
                => Description;         
        }    
    }
}