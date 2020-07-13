//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    
    public readonly struct Unaddressed : IProcessedEvent<Unaddressed>
    {
        public readonly OpUri Uri;
        public readonly LocatedCode Code;

        [MethodImpl(Inline)]
        public Unaddressed(OpUri uri, LocatedCode code)
        {
            Uri = uri;
            Code = code;
        }

        public AppMsgColor Flair 
            => AppMsgColor.Red;
                
        public string Description
            => $"The location for {Uri} code is unknown";
    }        
}