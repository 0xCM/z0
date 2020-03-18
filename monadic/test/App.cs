//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId("monadic.test")]

namespace Z0
{
    class App : TestApp<App>
    { 
        public static void Main(params string[] args) => Run(args); 
    } 
}

