//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;    

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class MklApi : AssemblyDesignator<MklApi>
    {
        const AssemblyId Identity = AssemblyId.MklApi;
        
        public override AssemblyId Id 
            => Identity;

    }

}