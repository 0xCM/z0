//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        /// <summary>
        /// Represents the logical negation of a distinguished subject
        /// </summary>
        public readonly struct Not<T> : IRule<Not<T>,T>
        {
            public T Element {get;}

            [MethodImpl(Inline)]
            public Not(T src)
                => Element = src;

            [MethodImpl(Inline)]
            public static implicit operator Not<T>(T src)
                => new Not<T>(src);
        }
    }
}