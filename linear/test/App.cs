//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    class App : TestApp<App>
    {                    

        protected override void RunTests(params string[] filters)
        {
            base.RunTests(filters);
        }
        
        public static void Main(params string[] args)
            => Run(args);
    
    }
}
