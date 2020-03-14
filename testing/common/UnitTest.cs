//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static Root;
    using static Nats;

    public abstract class UnitTest<U> : TestContext<U>, IUnitTest
        where U : UnitTest<U>
    {
        protected UnitTest()
            : base(null,null)
        {

        }

        protected UnitTest(ITestConfig config)
            : base(config, null)
            {

            }        


        public virtual void Dispose()
        {

        }

        protected virtual bool TraceDetailEnabled
            => false;
        
        /// <summary>
        /// Creates a new stopwatch and optionally start it
        /// </summary>
        /// <param name="start">Whether to start the new stopwatch</param>
        [MethodImpl(Inline)]   
        protected static Stopwatch stopwatch(bool start = true) 
            => start ? Stopwatch.StartNew() : new Stopwatch();

        /// <summary>
        /// Captures a stopwatch duration
        /// </summary>
        /// <param name="sw">A running/stopped stopwatch</param>
        [MethodImpl(Inline)]   
        protected static Duration snapshot(Stopwatch sw)     
            => Duration.Define(sw.ElapsedTicks);        

        /// <summary>
        /// Captures a stopwatch duration and the number of operations executed within the duration period
        /// </summary>
        /// <param name="sw">The running/stopped stopwatch</param>
        /// <param name="opcount">The operation count</param>
        /// <param name="label">The label associated with the measure, if specified</param>
        [MethodImpl(Inline)]   
        protected static BenchmarkRecord optime(long opcount, Stopwatch sw, [CallerMemberName] string label = null)
            => BenchmarkRecord.Define(opcount, snapshot(sw), label);

        /// <summary>
        /// Captures a duration and the number of operations executed within the period
        /// </summary>
        /// <param name="time">The running time</param>
        /// <param name="opcount">The operation count</param>
        /// <param name="label">The label associated with the measure, if specified</param>
        [MethodImpl(Inline)]   
        protected static BenchmarkRecord optime(long opcount, Duration time, [CallerMemberName] string label = null)
            => BenchmarkRecord.Define(opcount, time, label);


        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        protected void CheckAction(Action f, OpIdentity name, SystemCounter count = default)
        {
            var succeeded = true;
            
            count.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                term.error(e, name.Identifier);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(CaseName(name), succeeded,count);
            }
        }

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        protected void CheckAction(Action f, string name, SystemCounter count = default)
        {
            var succeeded = true;
            
            count.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                term.error(e, name);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(name,succeeded,count);
            }
        }
    }
}