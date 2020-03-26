//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Blocks;

    partial class XBlocks    
    {
       [MethodImpl(Inline)]
        public static void Fill<T>(this in Block16<T> dst, T data)
            where T : unmanaged
                => broadcast(data, dst);

       [MethodImpl(Inline)]
        public static void Fill<T>(this in Block32<T> dst, T data)
            where T : unmanaged
                => broadcast(data, dst);

        [MethodImpl(Inline)]
        public static void Fill<T>(this in Block64<T> dst, T data)
            where T : unmanaged
                => broadcast(data, dst);

        [MethodImpl(Inline)]
        public static void Fill<T>(this in Block128<T> dst, T data)
            where T : unmanaged
                => broadcast(data, dst);

        [MethodImpl(Inline)]
        public static void Fill<T>(this in Block256<T> dst, T data)
            where T : unmanaged
                => broadcast(data, dst);

        [MethodImpl(Inline)]
        public static void Fill<T>(this in Block512<T> dst, T data)
            where T : unmanaged
                => broadcast(data, dst);
    }
}