//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Tables
    {
        public static Index<string> fields(string src, char delimiter)
            => text.split(text.trim(src), delimiter);

        /// <summary>
        /// Discerns a <see cref='RecordFields'/> for a parametrically-identified record type
        /// </summary>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static RecordFields fields<T>()
            where T : struct
                => fields(typeof(T));

        /// <summary>
        /// Discerns a <see cref='RecordFields'/> for a specified record type
        /// </summary>
        /// <param name="src">The record type</typeparam>
        [Op]
        public static RecordFields fields(Type src)
            => RecordFields.discover(src);
    }
}