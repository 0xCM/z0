//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Records
    {
        /// <summary>
        /// Computes the <see cref='TableId'/> of a parametrically-identified record
        /// </summary>
        /// <typeparam name="T">The record type</typeparam>
        public static TableId tableid<T>()
            where T : struct
                => tableid(typeof(T));

        /// <summary>
        /// Computes the <see cref='TableId'/> of a specified record type
        /// </summary>
        /// <param name="src">The record type</typeparam>
        [Op]
        public static TableId tableid(Type src)
            => src.Tag<RecordAttribute>().MapValueOrElse(
                    a => new TableId(src, a.TableId),
                    () => new TableId(src, src.Name));
    }
}