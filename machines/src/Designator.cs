//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{    
    using System;

    public sealed class Machines : AssemblyDesignator<Machines>
    {
        public override AssemblyId Id => AssemblyId.Machines;
    }
}