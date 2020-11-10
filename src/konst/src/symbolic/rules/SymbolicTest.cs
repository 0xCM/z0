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
    public readonly struct SymbolicTest<S>
        where S : unmanaged
    {
        [MethodImpl(Inline)]
        public SymbolicTest(S condition)
        {
            Condition = condition;
        }

        /// <summary>
        /// The test condition
        /// </summary>
        public S Condition {get;}

        [MethodImpl(Inline)]
        public static implicit operator SymbolicTest<S>(S src)
            => new SymbolicTest<S>(src);
    }
}