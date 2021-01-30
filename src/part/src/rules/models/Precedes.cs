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
        /// Requires that one element occurrs before another
        /// </summary>
        public readonly struct Precedes<T> : IRule<Precedes<T>,T>
        {
            public T Before {get;}

            public T After {get;}

            [MethodImpl(Inline)]
            public Precedes(T before, T after)
            {
                Before = before;
                After = after;
            }
        }
    }
}