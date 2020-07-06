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
        public static BitStack Create(ulong state = 0)
            => new BitStack(state);            

        [MethodImpl(Inline)]
        internal BitStack(ulong state)
            => State  = state;

        [MethodImpl(Inline)]
        public void Push(Bit src)
        {
            State <<= 1;
            State |= (uint)src;
        }

        [MethodImpl(Inline)]
        public Bit Pop()
        {
            var val = (Bit)(State & 1);
            State >>= 1;
            return val;
        }
    }
}