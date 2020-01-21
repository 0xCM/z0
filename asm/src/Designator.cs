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
    public sealed class AsmCore : AssemblyDesignator<AsmCore>
    {
        public override AssemblyId Id => AssemblyId.AsmCore;
    }
}