//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Creates an undesirable computation outcome
        /// </summary>
        /// <param name="e">The exception that caused the outcome to achieve an undesirable state</param>
        /// <param name="data">A payload value, if any</param>
        /// <typeparam name="T">The result payload type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Outcome<T> failure<T>(Exception e, T data = default)
            => new Outcome<T>(e, data);
    }
}