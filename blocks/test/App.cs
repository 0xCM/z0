//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BlocksTest)]

namespace Z0
{
    using System;

    class App : Shell<App>
    { 
        public override void RunShell(params string[] args)
        {
            Console.WriteLine("I do nothing");
        }

        public static void Main(params string[] args) => Launch(args); 
    } 
}