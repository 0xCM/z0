//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CapturedPart : IAppEvent<CapturedPart>
    {            
        public readonly PartId Part;

        [MethodImpl(Inline)]
        public CapturedPart(PartId part)
            => Part = part;

        public string Description
            => $"{Part.Format()} capture completed";

        public CapturedPart Zero
            => Empty;
        
        public static CapturedPart Empty 
            => new CapturedPart(0);
    }    
}