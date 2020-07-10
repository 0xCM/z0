//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

[assembly: PartId(PartId.Math)]

namespace Z0.Parts
{    
    public sealed class Math : Part<Math>
    {        
        public override PartId[] Needs  
            => parts(PartId.Konst);        
    }
}

