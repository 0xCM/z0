//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        /// <summary>
        /// Requires that one element occurrs after another
        /// </summary>
        public readonly struct Follows<T> : IRule<Follows<T>,T>
        {
            public T Before {get;}

            public T After {get;}

            [MethodImpl(Inline)]
            public Follows(T before, T after)
            {
                Before = before;
                After = after;
            }
        }
    }
}