//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct BitStack
    {
        ulong State;

        [MethodImpl(Inline)]
        public BitStack(ulong state)
            => State  = state;

        [MethodImpl(Inline)]
        public void Push(bit src)
        {
            State <<= 1;
            State |= (uint)src;
        }

        [MethodImpl(Inline)]
        public BitState Pop()
        {
            var val = (bit)(State & 1);
            State >>= 1;
            return val;
        }
    }
}