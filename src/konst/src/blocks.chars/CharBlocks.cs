//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.CharBlocks)]
    public readonly partial struct CharBlocks
    {
        [MethodImpl(Inline)]
        public static ref T init<T>(ReadOnlySpan<char> src, out T dst)
            where T : unmanaged, ICharBlock<T>
        {
            dst = default;
            return ref copy(src, ref dst);
        }

        [MethodImpl(Inline)]
        public static ref T init<T>(ReadOnlySpan<char> src, in T t0, out T dst)
            where T : unmanaged, ICharBlock<T>
        {
            dst = t0;
            return ref copy(src, ref dst);
        }
    }
}