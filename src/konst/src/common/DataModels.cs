//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct DataModels
    {
        /// <summary>
        /// Defines a
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DataFlow<T[],BinaryCode> flow<T>(T[] src, BinaryCode dst)
            where T : struct
                => z.paired(src,dst);
    }

}