//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;

    public sealed class StatCore : AssemblyResolution<StatCore,StatCoreCatalog>
    {
        public const AssemblyId Identity = AssemblyId.StatCore;

        public StatCore() : base(Identity) {}
    
    }

    public class StatCoreCatalog : OpCatalog<StatCoreCatalog> 
    {
         public StatCoreCatalog() : base(StatCore.Identity) {} 
    }    
}