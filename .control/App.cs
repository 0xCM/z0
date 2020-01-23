//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    class Controller : ConsoleApp<Controller>
    {

        public Controller()
            : base(Rng.WyHash64(Seed64.Seed00))
        {

        }

        protected override void Execute(params string[] args)
        {
            
            //(new TestController()).Execute();
            (new ArchiveControl()).Execute();
        }

        static void Main(params string[] args)
            => Run(args);
    }
}