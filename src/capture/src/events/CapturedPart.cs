//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct CapturedPart : IWfEvent<CapturedPart>
    {            
        const string Pattern = "";

        public WfEventId Id  => WfEventId.define("Placeholder");

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