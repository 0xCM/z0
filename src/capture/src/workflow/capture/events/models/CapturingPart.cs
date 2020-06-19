//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CapturingPart : IAppEvent<CapturingPart>
    {            
        public readonly PartId Part;

        [MethodImpl(Inline)]
        public CapturingPart(PartId part)
        {
            Part = part;
        }

        public string Description
            => $"{Part.Format()} capture starting";

        public CapturingPart Zero
            => Empty;
        
        public static CapturingPart Empty 
            => new CapturingPart(0);
    }    
}