//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Konst)]

namespace Z0.Parts
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Z0.Konst;

    public sealed class Konst : Part<Konst>
    {
        static readonly TypeCodes Codes_Static = new TypeCodes(0);
        
        public Konst()
        {
            Codes_Instance = Codes_Static;
        }
        
        readonly TypeCodes Codes_Instance;

        public ref readonly TypeCodes Codes 
        {
            [MethodImpl(Inline)]
            get => ref Codes_Instance;
        }

        public override PartId[] Needs  
            => parts(PartId.Sys);
    }    
}