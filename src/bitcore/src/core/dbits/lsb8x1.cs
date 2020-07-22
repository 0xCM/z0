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

    partial class Bits
    {
         /// <summary>
        /// [00000001 ... 00000001]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static T lsb8x1<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(scatter(convert<T,ulong>(src), BitMasks.Lsb64x8x1));
    }
}