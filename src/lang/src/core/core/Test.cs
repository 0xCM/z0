//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Test
    {
        public IPredicate Condition {get;}

        [MethodImpl(Inline)]
        public Test(IPredicate condition)
        {
            Condition = condition;
        }
    }

    /// <summary>
    /// Represents a boolean evaluation
    /// </summary>
    public readonly struct Test<C>
    {
        /// <summary>
        /// The test condition
        /// </summary>
        public C Condition {get;}

        [MethodImpl(Inline)]
        public Test(C condition)
            => Condition = condition;

        [MethodImpl(Inline)]
        public static implicit operator Test<C>(C src)
            => new Test<C>(src);
    }
}