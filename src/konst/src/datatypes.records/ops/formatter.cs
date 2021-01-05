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
        /// Defines a <typeparamref name='T'/> record formatter
        /// </summary>
        /// <param name="spec">The format spec</param>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline)]
        public static RecordFormatter<T> formatter<T>(RowFormatSpec spec)
            where T : struct, IRecord<T>
                => new RecordFormatter<T>(spec);

        /// <summary>
        /// Defines a <typeparamref name='T'/> record formatter
        /// </summary>
        /// <param name="widths">The column widths</param>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline)]
        public static RecordFormatter<T> formatter<T>(ReadOnlySpan<byte> widths)
            where T : struct, IRecord<T>
                => formatter<T>(rowspec<T>(widths));
    }
}