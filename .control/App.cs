//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    class App : ConsoleApp<App>
    {

        public App()
            : base(Rng.WyHash64(Seed64.Seed00))
        {

        }

        protected override void OnExecute(params string[] args)
        {
            print("hello");
        }

        static void Main(params string[] args)
            => Run(args);
    }
}