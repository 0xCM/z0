//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    public sealed class Dynamic : AssemblyResolution<Dynamic, Dynamic.C>
    {
        public const AssemblyId Identity = AssemblyId.Dynamic;

        public Dynamic() : base(AssemblyId.Dynamic) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.Dynamic) { } }               
    }
}