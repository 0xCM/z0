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
    public readonly struct Test<C,T>
    {
        /// <summary>
        /// The test condition
        /// </summary>
        public Test<C> Condition {get;}

        /// <summary>
        /// The value to return if the condition succeeds
        /// </summary>
        public T IfTrue {get;}

        [MethodImpl(Inline)]
        public Test(Test<C> c, T t)
        {
            Condition = c;
            IfTrue = t;
        }

        [MethodImpl(Inline)]
        public static implicit operator Test<C,T>(Paired<C,T> src)
            => new Test<C,T>(src.Left, src.Right);
    }
}