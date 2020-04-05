//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Core
    {
        [MethodImpl(Inline)]
        public static T generic<T>(ulong src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref ulong src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static ulong uint64<T>(T src)
            => As.uint64(src);

        [MethodImpl(Inline)]
        public static ref ulong uint64<T>(ref T src)
            => ref As.uint64(ref src);
     
        [MethodImpl(Inline)]
        public static ulong? uint64<T>(T? src)
            where T : unmanaged
                => As.uint64(src);
    }
}