//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.LibMTest)]

namespace Z0.Parts
{        
    using System;

    public sealed class LibMTest : Part<LibMTest>
    {

    }
}

namespace Z0
{        
    using System;

    class App : TestApp<App>
    {            

        public static void Main(params string[] args)
            => Run(args);
    }
}