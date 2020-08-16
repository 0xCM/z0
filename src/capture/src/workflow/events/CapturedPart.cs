//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CapturedPart : IWfEvent<CapturedPart>
    {            
        const string Pattern = "";

        public WfEventId EventId  => WfEventId.define("Placeholder");

        public readonly PartId Part;

        [MethodImpl(Inline)]
        public CapturedPart(PartId part)
        {
            Part = part;
        }

        public string Format() 
            => $"{Part.Format()} capture completed";
    }    
}