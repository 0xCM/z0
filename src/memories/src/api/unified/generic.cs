//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        [MethodImpl(Inline)]
        public static T generic<T>(uint src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref uint src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static uint uint32<T>(T src)
            => As.uint32(src);

        [MethodImpl(Inline)]
        public static ref uint uint32<T>(ref T src)
            => ref As.uint32(ref src);

        [MethodImpl(Inline)]
        public static uint? uint32<T>(T? src)
            where T : unmanaged
                => As.uint32(src);
    }
}