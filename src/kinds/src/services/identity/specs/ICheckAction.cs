//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Konst;

    public interface ICheckAction : ITestChecker
    {
        /// <summary>
        /// Manages the execution of an action that performs a validation exercise
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        void CheckAction(Action f, string name)        
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
                ReportCaseResult(name,succeeded,count);
            }
        }
    }
}