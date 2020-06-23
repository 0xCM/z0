//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    public interface ITestAction : TTester
    {
        /// <summary>
        /// Captures the outcome of an action invocation, identified by a supplied label
        /// </summary>
        /// <param name="f">The action to invoke</param>
        /// <param name="label">The case label</param>
        TestCaseRecord TestAction(Action f, string label)
        {
            var succeeded = true;
            
            var clock = Time.counter(true);
            try
            {
                f();
                return TestCaseRecord.Define(label, true, clock);
            }
            catch(Exception e)
            {
                Print(e, label);
                return TestCaseRecord.Define(label, false, clock);
            }
        }

        /// <summary>
        /// Captures the outcome of an action invocation, identified by a supplied label
        /// </summary>
        /// <param name="f">The action to invoke</param>
        /// <param name="label">The case label</param>
        TestCaseRecord TestAction<T>(Action<T> f, T point, string label)
        {
            var succeeded = true;
            
            var clock = Time.counter(true);
            try
            {
                f(point);
                return TestCaseRecord.Define(label, true, clock);
            }
            catch(Exception e)
            {
                Print(e, label);
                return TestCaseRecord.Define(label, false, clock);
            }
        }

        /// <summary>
        /// Captures the outcome of action invocation, identified by a parametrically-specialized label
        /// </summary>
        /// <param name="f">The action to invoke</param>
        /// <param name="label">The case label to specialize</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        TestCaseRecord TestAction<T>(Action f, string label)
            where T : unmanaged
        {
            var succeeded = true;
            
            var clock = Time.counter(true);
            try
            {
                f();
                return TestCaseRecord.Define(CaseName<T>(label), true, clock);
            }
            catch(Exception e)
            {
                Print(e, label);
                return TestCaseRecord.Define(CaseName<T>(label), false, clock);
            }
        }
    }
}