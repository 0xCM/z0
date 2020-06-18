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
        public readonly struct FunctionsDecoded : IAppEvent<FunctionsDecoded>
        {
            public readonly ApiHostUri Host;
            
            public readonly AsmFunction[] Functions;

            [MethodImpl(Inline)]
            public FunctionsDecoded(ApiHostUri host, AsmFunction[] functions)
            {
                Host = host;
                Functions = functions;
            }
            
            public string Description
                => $"{Functions.Length} {Host} functions decoded";
            
            public FunctionsDecoded Zero 
                => Empty;

            public AppMsgColor Flair 
                => AppMsgColor.Magenta;            

            public static FunctionsDecoded Empty 
                => new FunctionsDecoded(ApiHostUri.Empty, Array.Empty<AsmFunction>());
        }    
    }
}