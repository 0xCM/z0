//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    public sealed class StatCore : AssemblyResolution<StatCore,StatCore.C>
    {
        public const AssemblyId Identity = AssemblyId.StatCore;

        public StatCore() : base(Identity) {}

        public class C : OpCatalog<C>  { public C() : base(StatCore.Identity) {} } 
    }
}