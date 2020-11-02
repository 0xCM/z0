//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents a parametric evaluation
    /// </summary>
    public readonly struct Test<C,T,F>
    {
        /// <summary>
        /// The test condition
        /// </summary>
        public Test<C> Condition {get;}

        /// <summary>
        /// The value to return if the condition succeeds
        /// </summary>
        public T WhenTrue {get;}

        /// <summary>
        /// The value to return if the condition succeeds
        /// </summary>
        public F WhenFalse {get;}

        [MethodImpl(Inline)]
        public Test(Test<C> condition, T @true, F @false)
        {
            Condition = condition;
            WhenTrue = @true;
            WhenFalse = @false;
        }
    }
}