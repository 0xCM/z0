//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
    
    public readonly struct Unaddressed : IWfEvent<Unaddressed>
    {        
        const string Pattern = IdMarker + "The location for {1} code is unknown";
        
        public WfEventId Id {get;}

        public readonly OpUri Uri;

        public readonly LocatedCode Code;

        [MethodImpl(Inline)]
        public Unaddressed(OpUri uri, LocatedCode code)
        {
            Id = WfEventId.define(nameof(Unaddressed));
            Uri = uri;
            Code = code;
        }

        public AppMsgColor Flair 
            => AppMsgColor.Red;
                
        public string Format()
            => text.format(Pattern, Id, Uri);
    }        
}