//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static unsafe ulong @ulong(bool src)
            => memory.@ulong(src);

        [MethodImpl(Inline)]
        public static unsafe ulong @ulong(double src)
            => memory.@ulong(src);

        [MethodImpl(Inline)]
        public static unsafe ulong @ulong(decimal src)
            => memory.@ulong(src);

        [MethodImpl(Inline)]
        public static unsafe ulong @ulong<T>(T src)
            where T : unmanaged
                => memory.@ulong(src);
    }
}