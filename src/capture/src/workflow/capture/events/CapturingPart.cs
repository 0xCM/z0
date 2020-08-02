//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CapturingPart : IWfEvent<CapturingPart>
    {            
        const string Pattern = "";

        public WfEventId Id  => WfEventId.define("Placeholder");

        public readonly PartId Part;

        [MethodImpl(Inline)]
        public CapturingPart(PartId part)
            => Part = part;

        public string Format() 
            => $"{Part.Format()} part capture step starting";

        public CapturingPart Zero
            => Empty;
        
        public static CapturingPart Empty 
            => new CapturingPart(0);
    }    
}