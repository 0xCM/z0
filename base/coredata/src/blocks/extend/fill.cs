//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static DataBlocks;

    partial class BlockExtend    
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

        [MethodImpl(Inline)]
        public static void Fill<N,T>(this in NatBlock<N,T> dst, T data)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => broadcast(data, dst);

    }

}