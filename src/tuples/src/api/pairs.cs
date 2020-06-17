//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    partial class Tuples
    {
        /// <summary>
        /// Allocates an homogenous pair store
        /// </summary>
        /// <param name="count">The store capacity</param>
        /// <typeparam name="T">The member type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static Pairs<T> pairs<T>(int count)
            where T : unmanaged
                => new Pairs<T>(new Pair<T>[count]);
    }
}