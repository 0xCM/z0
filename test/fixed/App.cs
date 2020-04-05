//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.FixedTest)]

namespace Z0.Parts
{        
    public sealed class FixedTest : Part<FixedTest>
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