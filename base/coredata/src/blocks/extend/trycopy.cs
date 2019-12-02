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
        public static bool TryCopyTo<T>(this Block32<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.TryCopyTo(dst);

        [MethodImpl(Inline)]
        public static void TryCopyTo<T>(this Block64<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.TryCopyTo(dst);

        [MethodImpl(Inline)]
        public static void TryCopyTo<T>(this Block128<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.TryCopyTo(dst);

        [MethodImpl(Inline)]
        public static void TryCopyTo<T>(this Block256<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.TryCopyTo(dst);

        [MethodImpl(Inline)]
        public static void TryCopyTo<T>(this ConstBlock32<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.TryCopyTo(dst);

        [MethodImpl(Inline)]
        public static void TryCopyTo<T>(this ConstBlock64<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.TryCopyTo(dst);

        [MethodImpl(Inline)]
        public static void TryCopyTo<T>(this ConstBlock128<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.TryCopyTo(dst);

        [MethodImpl(Inline)]
        public static void TryCopyTo<T>(this ConstBlock256<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.TryCopyTo(dst);
    }
}