//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct RecUtil
    {
        /// <summary>
        /// Allocates a <see cref='DynamicRow{T}'/>
        /// </summary>
        /// <param name="cells">The cell count</param>
        /// <typeparam name="T">The record type</typeparam>
        public static DynamicRow<T> row<T>(uint cells)
            where T : struct, IRecord<T>
                => new DynamicRow<T>(0, default(T), sys.alloc<dynamic>(cells));

        /// <summary>
        /// Creates and populates a <see cref='DynamicRow{T}'/>
        /// </summary>
        /// <param name="index">The row index</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The data type</typeparam>
        public static DynamicRow<T> row<T>(uint index, in T src)
            where T : struct, IRecord<T>
                => row(RecUtil.fields<T>(), index, src);

        /// <summary>
        /// Creates <see cref='DynamicRow{T}'/> from an indexed value
        /// </summary>
        /// <param name="fields">The defining fields</param>
        /// <param name="index">The value index</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The record type</typeparam>
        public static DynamicRow<T> row<T>(in RecordFields fields, uint index, in T src)
            where T : struct, IRecord<T>
        {
            var dst = row<T>(fields.Count);
            RecUtil.load(fields, index, src, ref dst);
            return dst;
        }
    }
}