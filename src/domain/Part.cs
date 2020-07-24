//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("Sequences of bits covered with semantic fabric")]
[assembly: PartId(PartId.Domain)]

namespace Z0.Parts
{        
    public sealed class Domain : Part<Domain> 
    {
        public override PartId[] Needs  
            => parts(PartId.Part, PartId.Sys);
    }
}