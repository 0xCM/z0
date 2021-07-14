//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Tables
    {
        /// <summary>
        /// Creates a table populate with a specified dataset
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static Table<T> load<T>(T[] src)
            where T : struct
                => new Table<T>(src);

        [Op, Closures(Closure)]
        public static void load<T>(in RecordField[] fields, uint index, in T src, ref DynamicRow<T> dst)
            where T : struct
        {
            dst = dst.UpdateSource(index, src);
            var tr = __makeref(edit(src));
            var count = fields.Length;
            var fv = @readonly(fields);
            var target = dst.Edit;
            for(var i=0u; i<count; i++)
                seek(target, i) = skip(fv, i).Definition.GetValueDirect(tr);
        }
    }
}