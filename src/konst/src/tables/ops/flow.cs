//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        /// <summary>
        /// Defines a
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static DataFlow<T[],BinaryCode> flow<T>(T[] src, BinaryCode dst)
            where T : struct
                => (src,dst);

        /// <summary>
        /// Creates a <see cref='StringTableCells'/> sequence from a <see cref='string'/> sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="dst">The target sequence</param>
        [MethodImpl(Inline), Op]
        public static DataFlow<string[],StringTableCells> flow(string[] src, ref StringTableCells dst)
        {
            var count = src.Length;
            ref var target = ref first(dst.Edit);
            ref readonly var input = ref first(@readonly(src));
            for(var i=0u; i<count; i++)
                seek(target,i) = skip(input,i);
            return (src,dst);
        }
    }
}