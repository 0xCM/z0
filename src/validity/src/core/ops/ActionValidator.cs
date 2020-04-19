//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;

    partial class TestContext<U>  
    {
        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="id">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        public void CheckAction(Action f, OpIdentity id)
        {
            var succeeded = true;
            var count = counter();
            
            count.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                term.errlabel(e, id.Identifier);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(CaseName(id), succeeded,count);
            }
        }

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        public void CheckAction(Action f, string name)
        {
            var succeeded = true;
            var count = counter();
            
            count.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                term.errlabel(e, name);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(name,succeeded,count);
            }
        }
    }
}