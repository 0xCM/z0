//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.NatsTest)]

namespace Z0.Parts
{        
    public sealed class NatsTest : Part<NatsTest>
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