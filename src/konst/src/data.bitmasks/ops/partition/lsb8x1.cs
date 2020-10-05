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

    using L = BitMasks.Literals;

    partial class BitMasks
    {
        /// <summary>
        /// [00000001 ... 00000001]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static T lsb8x1<T>(T src)
            where T : unmanaged
                => force<ulong,T>(scatter(force<T,ulong>(src), L.Lsb64x8x1));
    }
}