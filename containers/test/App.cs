//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.ContainerTest)]

namespace Z0
{
    class App : TestApp<App>
    { 
        public static void Main(params string[] args) => Run(args); 
    } 
}

namespace Z0.Parts
{
    public sealed class ContainerTest : Part<ContainerTest> { } 
}