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
        public readonly struct HexSaved : IAppEvent<HexSaved>
        {
            public readonly ApiHostUri Host;
            
            public readonly UriHex[] Code;

            public readonly FilePath Target;
            
            [MethodImpl(Inline)]
            public HexSaved(ApiHostUri host, UriHex[] code, FilePath dst)
            {
                Host = host;
                Code = code;
                Target = dst;
            }
            
            public string Description
                => $"{Code.Length} {Host} functions saved to {Target}";
            
            public HexSaved Zero 
                => Empty;            

            public AppMsgColor Flair 
                => AppMsgColor.Cyan;

            public static HexSaved Empty 
                => new HexSaved(ApiHostUri.Empty, Array.Empty<UriHex>(), FilePath.Empty);
        }    
    }
}