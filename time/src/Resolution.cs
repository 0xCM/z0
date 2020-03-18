//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Time)]

namespace Z0.Resolutions
{        
    public sealed class Time : AssemblyResolution<Time, Time.C>
    {
        public Time() : base(AssemblyId.Time){}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Time) { } }
    }    
}