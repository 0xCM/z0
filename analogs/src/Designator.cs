//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    using System;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class Analogs : AssemblyResolution<Analogs>
    {
        const AssemblyId Identity = AssemblyId.Analogs;

        public Analogs() : base(Identity) {}

        public class C : OpCatalog<C> { public C() : base(Identity){ }}
    }
}