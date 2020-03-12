//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Threading;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Z0.Machines;

    using static zfunc;

    using static Fsm1Spec.States;
    
    public class Fsm1Test : UnitTest<Fsm1Test>
    {

        public void Run()
        {
            var spec = new Fsm1Spec();
            var tasks = new Task[Pow2.T08];
            var indices = Numeric.range(0xFFFFul, 0xFFFFFFFFul).Where(x => x % 2 != 0).Take(Pow2.T08).ToArray();
            for(var i=0u; i< tasks.Length; i++)
            {
                var random = Rng.polyrand(Rng.Pcg64(0,indices[i]));
                var context = Fsm.CreateContext(random);
                var machine = Fsm.Machine($"Fsm1-{i}",context, S0,S5, spec.TransFunc);
                tasks[i] = Fsm.Run(machine);
            }
            Task.WaitAll(tasks);                            
        }


    }
}