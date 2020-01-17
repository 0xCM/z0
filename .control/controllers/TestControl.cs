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

    using Z0.Designators;

    using C = Z0.Designators.Control;
    using D = Z0.Designators;
    
    using static ControlMessages;
    using static zfunc;

    class TestController : Controller<TestController>
    {        

        public TestController()
        {

        }

        static IEnumerable<IAssemblyDesignator> TestHosts
            => C.Designated.Designates.Where(d => d.Role == AssemblyRole.Test).Select(x => x);

        static double RunTests(IAssemblyDesignator host)
        {
            var clock = counter(true);
            var runtime = 0.0;
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
        
        static string[] ConcurrentTests
            => new string[]{
                D.NatTest.Designated.Name,
                D.CoreFuncTest.Designated.Name,     
                D.GMathTest.Designated.Name,
                D.IntrinsicsTest.Designated.Name,
                D.BitCoreTest.Designated.Name,
                D.BitVectorTest.Designated.Name,
                D.BitTest.Designated.Name,
                D.LogixTest.Designated.Name,
                D.LinearTest.Designated.Name,
                
            };

        static string[] SequentialTests
            => new string[]
        {
            D.MklTest.Designated.Name,
            D.LibMTest.Designated.Name
        };

        public static T[] freeze<T>(IEnumerable<T> src)
            => src.ToArray();

        static long RunTests()
        {
            var runtime = 0L;

            var concurrent =  freeze(from h in TestHosts where ConcurrentTests.Contains(h.Name) select h);
            var sequential = freeze(from h in TestHosts where SequentialTests.Contains(h.Name) select h);
            try
            {            
                concurrent.AsParallel().ForAll(h => Interlocked.Add(ref runtime, (long)RunTests(h)));                
                foreach(var host in sequential)
                     runtime += (long)RunTests(host);

            }
            catch(Exception e)
            {
                error(e);
            }
            
            return runtime;
        }

        public override void Execute()
        {
           print(ExecutingSuites());
           
           var runtime = RunTests();
           
           print(FinishedSuiteExecution(runtime));
        }
    }
}