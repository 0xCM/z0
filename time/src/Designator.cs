//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;
    

    public sealed class Time : AssemblyResolution<Time, Time.C>
    {
        public const AssemblyId Identity = AssemblyId.Time;

        public Time() : base(Identity){}

        public class C : OpCatalog<C> { public C() : base(Identity) { } }            
    }
}