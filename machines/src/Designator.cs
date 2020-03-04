//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{    
    using System;

    public sealed class Machines : AssemblyResolution<Machines>
    {
        const AssemblyId Identity = AssemblyId.Machines;

        public override AssemblyId Id 
            => Identity;
    }
}