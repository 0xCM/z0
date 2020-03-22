//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.RootTest)]

namespace Z0.Resolutions
{        
    public sealed class RootTest : ApiResolution<RootTest>
    {

    }
}

namespace Z0
{ 
    class App : TestApp<App> 
    {
        public static void Main(params string[] args) => Run(args);
    }
}