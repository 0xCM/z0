//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        

    sealed class App : AppContext<App>
    {            
        public App()
            : base(Rng.XOrShift1024(Seed1024.TestSeed).ToPolyrand())
        {

        }

        public override void Run()
        {

        }        
        public static void Main(params string[] args)
            => RunApp();
    }

}