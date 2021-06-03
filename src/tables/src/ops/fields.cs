//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Tables
    {
        public static ReadOnlySpan<string> fields(string src, char delimiter)
            => src.Trim().SplitClean(delimiter);

        /// <summary>
        /// Discerns a <see cref='RecordFields'/> for a parametrically-identified record type
        /// </summary>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static RecordField[] fields<T>()
            where T : struct
                => fields(typeof(T));

        /// <summary>
        /// Discerns a <see cref='RecordFields'/> for a specified record type
        /// </summary>
        /// <param name="src">The record type</typeparam>
        [Op]
        public static RecordField[] fields(Type src)
            => RecordFields.discover(src);
    }
}