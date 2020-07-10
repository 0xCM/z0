//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.GMath)]

namespace Z0.Parts
{
    public sealed class GMath : Part<GMath>
    {        
        public override PartId[] Needs  
            => parts(PartId.Seed, PartId.Math);        
    }
}