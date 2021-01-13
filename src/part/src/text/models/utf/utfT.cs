//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct utf<T>
        where T : unmanaged
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public utf(T[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator utf<T>(T[] src)
            => new utf<T>(src);
    }
}