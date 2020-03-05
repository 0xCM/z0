//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class Math : AssemblyResolution<Math, Math.C>
    {
        public Math() : base(AssemblyId.Math) {}
        
        public class C : OpCatalog<C> { public C() : base(AssemblyId.Math) {} }            
    }
}