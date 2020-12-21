//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Records
    {
        /// <summary>
        /// Allocates a <see cref='DynamicRow{T}'/>
        /// </summary>
        /// <param name="cells">The cell count</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(uint cells)
            where T : struct
                => new DynamicRow<T>(0, default(T), sys.alloc<dynamic>(cells));

        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(uint index, in T src)
            where T : struct
                => row(fields<T>(), index, src);

        /// <summary>
        /// Creates <see cref='DynamicRow{T}'/> from an indexed value
        /// </summary>
        /// <param name="fields">The defining fields</param>
        /// <param name="index">The value index</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(in RecordFields fields, uint index, in T src)
            where T : struct
        {
            var dst = Records.row<T>(fields.Count);
            load(fields, index, src, ref dst);
            return dst;
        }

        /// <summary>
        /// Creates a <see cref='DynamicRow{T}'/> from a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(in T src)
            where T : struct
                => adapter<T>().Adapt(src).Adapted;

        /// <summary>
        /// Creates a <see cref='DynamicRow{T}'/> from a specified value and an adapter
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="adapter">A compatible adapter</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(in T src, in RowAdapter<T> adapter)
            where T : struct
                => adapter.Adapt(src).Adapted;

        /// <summary>
        /// Creates a <see cref='DynamicRow{T}'/> from a specified value and a conforming <see cref='RecordFields'/> sequence
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="fields">The defining fields</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(in T src, in RecordFields fields)
            where T : struct
                => adapter<T>(fields).Adapt(src).Adapted;
    }
}