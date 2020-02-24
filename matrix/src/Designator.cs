//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    public sealed class Matrix : AssemblyResolution<Matrix>
    {
        const AssemblyId Identity = AssemblyId.Matrix;

        public override AssemblyId Id 
            => Identity;
    }
}