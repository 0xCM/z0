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
    public sealed class LinearOps : AssemblyDesignator<LinearOps>
    {
        const AssemblyId Identity = AssemblyId.LinearOps;

        public override AssemblyId Id 
            => Identity;            
    }
}