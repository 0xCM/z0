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
        public static void CopyTo<T>(this in Block16<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this in Block32<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this in Block64<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this in Block128<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this in Block256<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this in Block512<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);
    }
}