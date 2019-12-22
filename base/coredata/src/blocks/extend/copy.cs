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

    partial class BlockExtend    
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

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this in ConstBlock16<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this in ConstBlock32<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this in ConstBlock64<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this in ConstBlock128<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this in ConstBlock256<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this in ConstBlock512<T> src, Span<T> dst)
            where T : unmanaged
                => src.Data.CopyTo(dst);

    }
}