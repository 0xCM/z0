//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

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
                error(e, name);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(name,succeeded,count);
            }
        }

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="t">A discrinator representative</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        /// <typeparam name="T">The discriminator type</typeparam>
        protected void CheckAction<T>(Action f, string name, T t = default, SystemCounter clock = default)
        {
            var casename = CaseName(name,t);
            var succeeded = true;
            
            clock.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,clock);
            }
        }
    }
}