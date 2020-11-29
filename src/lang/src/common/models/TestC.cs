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
    /// Represents a boolean evaluation
    /// </summary>
    public readonly struct Test<C>
    {
        [MethodImpl(Inline)]
        public Test(C condition)
        {
            Condition = condition;
        }

        /// <summary>
        /// The test condition
        /// </summary>
        public C Condition {get;}

        [MethodImpl(Inline)]
        public static implicit operator Test<C>(C src)
            => new Test<C>(src);
    }
}