//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Time)]

namespace Z0.Parts
{        
    public sealed class Time : ApiResolution<Time, Time.C>
    {
        public Time() : base(AssemblyId.Time){}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Time) { } }
    }    
}