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
    public sealed class MathObjects : AssemblyDesignator<MathObjects>
    {
        const AssemblyId Identity = AssemblyId.MathObjects;

        public override AssemblyId Id 
            => Identity;
    }
}