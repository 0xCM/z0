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
        public static void Fill<T>(this in Block16<T> src,T value)
            where T : unmanaged
                => src.Data.Fill(value);

       [MethodImpl(Inline)]
        public static void Fill<T>(this in Block32<T> src,T value)
            where T : unmanaged
                => src.Data.Fill(value);

        [MethodImpl(Inline)]
        public static void Fill<T>(this in Block64<T> src,T value)
            where T : unmanaged
                => src.Data.Fill(value);

        [MethodImpl(Inline)]
        public static void Fill<T>(this in Block128<T> src,T value)
            where T : unmanaged
                => src.Data.Fill(value);

        [MethodImpl(Inline)]
        public static void Fill<T>(this in Block256<T> src,T value)
            where T : unmanaged
                => src.Data.Fill(value);

        [MethodImpl(Inline)]
        public static void Fill<N,T>(this in NatBlock<N,T> src,T value)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.Fill(value);

    }

}