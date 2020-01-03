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
    
    using C = Z0.Designators.Control;
    
    using static ControlMessages;
    using static zfunc;

    class Controller : ConsoleApp<Controller>
    {
        IEnumerable<IAssemblyDesignator> TestHosts
            => C.Designated.Designates.Where(d => d.Role == AssemblyRole.Test).Select(x => x);

        double RunTests(IAssemblyDesignator host)
        {
            var clock = counter(true);
            var runtime = 0.0;
            //clock.Start();
            print(ExecutingHost(host));

            try
            {
                host.Run();
            }
            catch(Exception e)
            {
                error(e);
            }
            finally
            {
                clock.Stop();
                runtime = clock.Time.TotalMilliseconds;
                print(FinishedHostExecution(host,runtime));
            }
            
            return runtime;
        }
        
        double RunTests()
        {
            var runtime = 0.0;
            foreach(var host in TestHosts)
                runtime += RunTests(host);
            return runtime;
        }

        public Controller()
            : base(Rng.WyHash64(Seed64.Seed00))
        {

        }

        protected override void OnExecute(params string[] args)
        {
           print(ExecutingSuites());
           
           var runtime = RunTests();
           
           print(FinishedSuiteExecution(runtime));

        }

        static void Main(params string[] args)
            => Run(args);
    }
}