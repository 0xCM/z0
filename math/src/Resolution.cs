//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Math)]

namespace Z0.Resolutions
{
    public sealed class Math : AssemblyResolution<Math, Math.C>
    {
        public Math() : base(AssemblyId.Math) {}
        
        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.Math) {} }            
    }
}