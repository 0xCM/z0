//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public struct Bitfield64<T>
        where T : unmanaged
    {
        ulong State;

        [MethodImpl(Inline)]
        public Bitfield64(T state)
            => State = uint64(state);
    }
}