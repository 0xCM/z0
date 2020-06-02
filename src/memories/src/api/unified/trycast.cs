//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        /// <summary>
        /// Casts a value to a parametric type, if possible, otherwise returns none
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The object to cast</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]   
        public static Option<T> TryCast<T>(object src)
            => Option.TryCast<T>(src);
    }
}