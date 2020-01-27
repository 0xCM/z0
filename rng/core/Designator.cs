//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;

    public sealed class RngCore : AssemblyDesignator<RngCore>
    {
        const AssemblyId Identity = AssemblyId.RngCore;

        public override AssemblyId Id 
            => AssemblyId.RngCore;
    }
}