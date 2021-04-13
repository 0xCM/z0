//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Tables
    {
        /// <summary>
        /// Computes the <see cref='TableId'/> of a parametrically-identified record
        /// </summary>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline)]
        public static TableId tableid<T>()
            where T : struct, IRecord<T>
                => TableId.identify<T>();

        /// <summary>
        /// Computes the <see cref='TableId'/> of a specified record type
        /// </summary>
        /// <param name="src">The record type</typeparam>
        [Op]
        public static TableId tableid(Type src)
            => TableId.identify(src);
    }
}