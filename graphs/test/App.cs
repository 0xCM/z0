//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.GraphTest)]

namespace Z0
{
    using System;

    class App : Shell<App>
    { 
        protected override void Execute(params string[] args)
        {
            Console.WriteLine("I do nothing");
        }

        public static void Main(params string[] args) => Launch(args); 
    } 
}

namespace Z0.Parts
{
    public sealed class GraphTest : Part<GraphTest> 
    {

    } 
}