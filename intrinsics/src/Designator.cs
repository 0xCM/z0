//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;
    using static ginx;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class Intrinsics : AssemblyDesignator<Intrinsics>
    {
        public override IEnumerable<string> OpNames
            => set(
                
                nameof(vadd), nameof(vsub), nameof(vnegate), nameof(vinc), nameof(vdec), 
                nameof(vgt), nameof(vlt),
                
                nameof(vand), nameof(vor), nameof(vxor),
                nameof(vnand), nameof(vnor), nameof(vxnor),
                nameof(vxornot),
                nameof(vimpl), nameof(vnonimpl), nameof(vcimpl), nameof(vcnonimpl), 
                nameof(vnot),

                nameof(vsll), nameof(vsrl), nameof(vxors),                
                nameof(vselect) 
                );
            

    }

}