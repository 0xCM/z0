//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using C = Z0.Designators.Control;
    using D = Z0.Designators;
    
    using static ControlMessages;
    using static zfunc;

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
            //iter(C.Designated.Designates, d => print(d.Name));
        }

        static void Main(params string[] args)
            => Run(args);
    }
}