//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    using System;
    

    public sealed class Workflow : AssemblyResolution<Workflow, Workflow.C>
    {
        public const AssemblyId Identity = AssemblyId.Workflow;

        public Workflow() : base(Identity){}

        public class C : OpCatalog<C> { public C() : base(Identity) { } }            
    }
}