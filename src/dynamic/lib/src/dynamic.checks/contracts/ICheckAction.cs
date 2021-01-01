//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ICheckAction : ITester, TTestResultSink
    {
        /// <summary>
        /// Manages the execution of an action that performs a validation exercise
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        void CheckAction(Action f, string name)
        {
            var succeeded = true;
            var count = Time.counter(true);
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
                ReportCaseResult(name, succeeded, count);
            }
        }
    }
}