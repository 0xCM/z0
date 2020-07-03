//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("A seed no longer")]
[assembly: PartId(PartId.Seed)]

namespace Z0.Parts
{        
    public sealed class Seed : Part<Seed>
    {
        static readonly TypeCodes Codes = TypeCodes.init();

        public Seed()
            : base(Refs.boxed(Codes))
        {
            
        }    
    }
}
