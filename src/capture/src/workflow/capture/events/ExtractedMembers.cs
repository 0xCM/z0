//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ExtractedMembers : IAppEvent<ExtractedMembers>
    {            
        public readonly PartId Part;

        [MethodImpl(Inline)]
        public ExtractedMembers(PartId part)
            => Part = part;

        public string Description
            => $"{Part.Format()} capture completed";

        public ExtractedMembers Zero
            => Empty;
        
        public static ExtractedMembers Empty 
            => default;
    }    
}