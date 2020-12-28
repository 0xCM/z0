//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Table
    {
        /// <summary>
        /// Determines the <see cref='TableId'/> for a parametrically-identified record
        /// </summary>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline)]
        public static TableId id<T>()
            where T : struct, IRecord<T>
                => id(typeof(T));

        /// <summary>
        /// Determines the <see cref='TableId'/> for a specified record type
        /// </summary>
        /// <param name="src">The record type</param>
        [Op]
        public static TableId id(Type src)
            => src.Tag<RecordAttribute>().MapValueOrElse(
                    a => new TableId(src, a.TableId),
                    () => new TableId(src, src.Name));
    }
}