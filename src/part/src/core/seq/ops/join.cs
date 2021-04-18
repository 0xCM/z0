//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Seq
    {
        /// <summary>
        /// All of your streams belong to us
        /// </summary>
        /// <param name="src">The source streams</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [Op, Closures(Closure)]
        public static Deferred<T> join<T>(params IEnumerable<T>[] src)
            => src.SelectMany(x => x);
    }
}