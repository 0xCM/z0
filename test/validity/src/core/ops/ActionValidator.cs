//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;


    partial class TestContext<U>  
    {
        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        public void CheckAction(Action f, OpIdentity name)
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
                term.errlabel(e, name.Identifier);
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
                ReportOutcome(name,succeeded,count);
            }
        }
    }
}