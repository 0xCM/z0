//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: AssemblyDescription("Driven, parametrically")]
[assembly: PartId(PartId.WfActors)]

namespace Z0.Parts
{        
    public sealed class Imagine : Part<Imagine> 
    {
        public override PartId[] Needs  
            => parts(PartId.Konst);
    }
}