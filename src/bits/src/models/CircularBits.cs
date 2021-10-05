//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiComplete]
    public struct CircularBits
    {
        [MethodImpl(Inline)]
        public static CircularBits create(ulong state)
            => new CircularBits(state);

        ulong State;

        [MethodImpl(Inline)]
        public CircularBits(ulong state)
            => State  = state;

        [MethodImpl(Inline)]
        public ulong Push(bit src)
        {
            State <<= 1;
            State |= (uint)src;
            return State;
        }

        [MethodImpl(Inline)]
        public bit Pop()
        {
            var val = (bit)(State & 1);
            State >>= 1;
            return val;
        }
    }
}