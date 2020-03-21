//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.RngTest)]

namespace Z0
{            
    class App : TestApp<App> { public static void Main(params string[] args) => Run(args); }
}

namespace Z0.Resolutions
{        
    public sealed class RngCoreTest : ApiResolution<RngCoreTest>
    {
        
    }
}