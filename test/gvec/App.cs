//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    class App : TestApp<App>
    {                    
        protected override void RunTests(params string[] filters) => base.RunTests(filters);

        public static void Main(params string[] args) => Run(args);    
    }
}