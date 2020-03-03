//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class CoreFunc : AssemblyResolution<CoreFunc, CoreFunc.C>
    {
        const AssemblyId Identity = AssemblyId.CoreFunc;

        public CoreFunc() : base(Identity) {}
        
        public class C : OpCatalog<C> { public C() : base(Identity) { } }
    }
}