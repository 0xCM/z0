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
        /// [00000000 00000000 00000000 0000001 00000000 00000000 00000000 0000001]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static T lsb32x1<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bit.scatter(convert<T,ulong>(src), L.Lsb64x32x1));
    }
}