//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct BitFieldModels
    {
        /// <summary>
        /// Defines a <see cref='BitSection{T}'/>
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitSection<T> section<T>(T min, T max)
            where T : unmanaged
                => new BitSection<T>(min, max);
    }
}