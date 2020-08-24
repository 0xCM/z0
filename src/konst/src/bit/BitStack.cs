//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct BitStack
    {
        ulong State;

        [MethodImpl(Inline)]
        public BitStack(ulong state)
            => State  = state;

        [MethodImpl(Inline)]
        public void Push(BitState src)
        {
            State <<= 1;
            State |= (uint)src;
        }

        [MethodImpl(Inline)]
        public BitState Pop()
        {
            var val = (BitState)(State & 1);
            State >>= 1;
            return val;
        }
    }
}