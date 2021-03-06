//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Sources
    {
        [MethodImpl(Inline)]
        public static ref readonly T next<T>(in CellCycle<T> src)
            where T : unmanaged, IDataCell<T>
                => ref src.Next();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T next<T>(in ValueCycle<T> src)
            where T : unmanaged
                => ref src.NextRef();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T next<T>(ISource src)
            where T : struct
                => src.Next<T>();

        /// <summary>
        /// Produces the next value from a specified <see cref='IDomainSource'/> source subject to specified domain constraints
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="max">The maximum value to produce</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T next<T>(IDomainSource src, T max)
            where T : unmanaged
                => src.Next<T>(max);

        /// <summary>
        /// Produces the next value from a specified <see cref='IDomainSource'/> source subject to specified domain constraints
        /// </summary>
        /// <param name="src">The value source</param>
        /// <param name="min">The minimum value to produce</param>
        /// <param name="max">The maximum value to produce</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T next<T>(IDomainSource src, T min, T max)
            where T : unmanaged
                => src.Next<T>(min, max);
    }
}