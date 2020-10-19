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
        /// Creates a positive computation outcome
        /// </summary>
        /// <param name="data">The computation result</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Outcome<T> success<T>(T data)
            => new Outcome<T>(true,data);
    }
}