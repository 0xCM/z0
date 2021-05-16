//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    partial struct Tables
    {
        /// <summary>
        /// Adapts a <see cref='RecordFields'/> sequence to a <typeparamref name='T'/> parametric row
        /// </summary>
        /// <param name="fields">The record fields</param>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline)]
        public static RowAdapter<T> adapter<T>(in RecordFields fields)
            where T : struct, IRecord<T>
                => new RowAdapter<T>(fields);

        /// <summary>
        /// Creates a <see cref='RowAdapter{T}'/> predicated a specified <typeparamref name='T'/>
        /// </summary>
        /// <typeparam name="T">The row type</typeparam>
        public static RowAdapter<T> adapter<T>()
            where T : struct, IRecord<T>
                => adapter<T>(fields<T>());
    }
}