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
        /// Records a record sequence emission to a file
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op]
        public static TableEmission<T> emission<T>(T[] src, FS.FilePath dst)
            where T : struct
                => new TableEmission<T>(src,dst);

        [MethodImpl(Inline), Op]
        public static TableEmission<T> emission<T>(Index<T> src, FS.FilePath dst)
            where T : struct
                => new TableEmission<T>(src, dst);

        /// <summary>
        /// Records a record sequence emission to a file
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op]
        public static RowsetEmissions<DynamicRow<T>> emission<T>(DynamicRows<T> src, FS.FilePath dst)
            where T : struct
                => new RowsetEmissions<DynamicRow<T>>(src.Rowset, dst);
    }
}