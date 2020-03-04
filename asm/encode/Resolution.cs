//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    using System;

    public sealed class AsmEncoder : AssemblyResolution<AsmEncoder, AsmEncoder.C>
    {
        public AsmEncoder() : base(AssemblyId.AsmEncoder) {}
        

        public class C : OpCatalog<C> { public C() : base(AssemblyId.AsmEncoder) {} }            
    }
}