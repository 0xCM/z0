//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class CaptureWorkflowEvents
    {
        public readonly struct HostCodeSaved : IAppEvent<HostCodeSaved>
        {
            public readonly ApiHostUri Host;
            
            public readonly UriCode[] Code;

            public readonly FilePath Target;
            
            [MethodImpl(Inline)]
            public HostCodeSaved(ApiHostUri host, UriCode[] code, FilePath dst)
            {
                Host = host;
                Code = code;
                Target = dst;
            }
            
            public string Description
                => $"{Code.Length} {Host} functions saved to {Target}";
                
            public HostCodeSaved Zero 
                => Empty;            

            public static HostCodeSaved Empty 
                => new HostCodeSaved(ApiHostUri.Empty, Array.Empty<UriCode>(), FilePath.Empty);
        }    
    }
}