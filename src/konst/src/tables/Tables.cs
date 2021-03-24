//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct Tables
    {
        const NumericKind Closure = UnsignedInts;

        public const string DefaultDelimiter = " | ";

        /// <summary>
        /// Creates a <see cref='DynamicRow{T}'/> from a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The record type</typeparam>
        public static DynamicRow<T> row<T>(in T src)
            where T : struct, IRecord<T>
                => RecUtil.adapter<T>().Adapt(src).Adapted;

        /// <summary>
        /// Creates a <see cref='DynamicRow{T}'/> from a specified value and an adapter
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="adapter">A compatible adapter</param>
        /// <typeparam name="T">The record type</typeparam>
        public static DynamicRow<T> row<T>(in T src, in RowAdapter<T> adapter)
            where T : struct, IRecord<T>
                => adapter.Adapt(src).Adapted;

        /// <summary>
        /// Creates a <see cref='DynamicRow{T}'/> from a specified value and a conforming <see cref='RecordFields'/> sequence
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="fields">The defining fields</param>
        /// <typeparam name="T">The record type</typeparam>
        public static DynamicRow<T> row<T>(in T src, in RecordFields fields)
            where T : struct, IRecord<T>
                => RecUtil.adapter<T>(fields).Adapt(src).Adapted;
    }

    partial struct Msg
    {
        public static MsgPattern<uint,uint> RecordFieldWidthMismatch
            => "The record field count of {0} does not match the supplied width count of {1}";
    }
}