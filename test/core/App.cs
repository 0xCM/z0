//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.CoreTest)]

namespace Z0.Parts
{        
    public sealed class CoreTest : Part<CoreTest>
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