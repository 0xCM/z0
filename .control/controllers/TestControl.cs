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

    using Z0.AsmSpecs;

    using C = Z0.Designators.Control;
    using D = Z0.Designators;
    
    using static ControlMessages;
    using static zfunc;

    class TestController : Controller<TestController>
    {       
        readonly IAsmContext Context;
        
        public TestController()
        {
            this.Context = AsmContext.New(C.Resolution.Designates.Where(d => d.Id.IsTest()).Select(x => x).ToArray());
        }

        static IEnumerable<IAssemblyResolution> TestHosts
            => C.Resolution.Designates.Where(d => d.Id.IsTest()).Select(x => x);

        // AsmFunction[] ResolveExample<T>(in CaptureExchange exchange, N128 w, T t = default)
        //     where T : unmanaged
        // {
        //     var imm = new byte[]{199,205};
        //     var c1 = Context.ImmCaptureService(VX.vbsll(w,t));
        //     var r1 = c1.Capture(exchange, imm);

        //     var c2 = Context.ImmCaptureService(VX.vsrl(w,t));
        //     var r2 = c2.Capture(exchange, imm);

        //     var c3 = Context.ImmCaptureService(VX.vblend8x16(w,t));
        //     var r3 = c3.Capture(exchange, imm);
        //     return r1.Union(r2).Union(r3).ToArray();
        // }

        // AsmFunction[] ResolveExample<T>(in CaptureExchange exchange, N256 w, T t = default)
        //     where T : unmanaged
        // {
        //     var imm = new byte[]{199,205};
        //     var c1 = Context.ImmCaptureService(VX.vbsll(w,t));
        //     var r1 = c1.Capture(exchange,imm);

        //     var c2 = Context.ImmCaptureService(VX.vsrl(w,t));
        //     var r2 = c2.Capture(exchange,imm);

        //     return r1.Union(r2).ToArray();            
        // }

        static double RunTests(IAssemblyResolution host)
        {
            var clock = SystemCounter.Create(true);
            var runtime = 0.0;
            print(ExecutingHost(host));

            try
            {
                host.Run();
            }
            catch(Exception e)
            {
                errout(e);
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
                D.NatsTest.Resolution.Name,
                D.CoreFuncTest.Resolution.Name,     
                D.GMathTest.Resolution.Name,
                D.IntrinsicsTest.Resolution.Name,
                D.BitCoreTest.Resolution.Name,
                D.BitVectorTest.Resolution.Name,
                D.BitGridsTest.Resolution.Name,
                D.LogixTest.Resolution.Name,
                
            };

        static string[] SequentialTests
            => new string[]
        {
            D.MklApiTest.Resolution.Name,
            D.LibMTest.Resolution.Name
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
                errout(e);
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