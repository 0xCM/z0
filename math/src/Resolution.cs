//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Math)]

namespace Z0.Parts
{
    public sealed class Math : ApiResolution<Math, Math.C>
    {
        public Math() : base(AssemblyId.Math) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Math) {} }            
    }
}