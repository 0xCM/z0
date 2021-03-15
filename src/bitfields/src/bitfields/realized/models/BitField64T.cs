//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public struct BitField64<T>
        where T : unmanaged
    {
        ulong State;

        [MethodImpl(Inline)]
        public BitField64(T state)
            => State = uint64(state);
    }
}