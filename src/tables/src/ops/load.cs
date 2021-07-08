//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Tables
    {
        /// <summary>
        /// Creates a table populate with a specified dataset
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The record type</typeparam>
        public static Table<T> load<T>(T[] src)
            where T : struct, IRecord<T>
                => new Table<T>(src);

    }
}