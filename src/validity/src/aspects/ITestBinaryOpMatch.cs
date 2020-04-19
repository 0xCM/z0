//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Seed;
    using static Memories;

    /// <summary>
    /// Defines operations that determine whether pairs of binary operators produce identical results 
    /// when evaluated over identical input sequences
    /// </summary>
    public interface ITestBinaryOpMatch : ITestAction, ICheckNumericEquality
    {
        /// <summary>
        /// Evaluates a pair of binary operators and asserts their equality over a random sequence
        /// </summary>
        /// <param name="label">The case label</param>
        /// <param name="f">The first operator, often interpreted as the reference implementation</param>
        /// <param name="g">The second operator, often interpreted as the operator under test</param>
        /// <typeparam name="T">The operator domain type</typeparam>
        TestCaseRecord TestMatch<T>(string label, BinaryOp<T> f, BinaryOp<T> g)
            where T :unmanaged
        {
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.Next<T>();
                    var y = Random.Next<T>();                    
                    eq(f(x,y),g(x,y));
                }
            }

            return TestAction<T>(check, label);
        }        



    }
}