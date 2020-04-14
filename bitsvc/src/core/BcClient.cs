//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [ApiHost]
    public readonly struct BcClient : IApiHost<BcClient>
    {
        [MethodImpl(Inline), Op, Closures(Numeric16x32x64u)]
        public static T byteswap<T>(T a)
            where T : unmanaged        
                => BC.byteswap<T>().Invoke(a);


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T bitslice<T>(T src, byte a, byte b)
            where T : unmanaged        
                => BC.bitslice<T>().Invoke(src,a,b);


   }
}