//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public ref struct BitStack
    {
        ulong state;

        [MethodImpl(Inline)]
        internal BitStack(ulong state)
            => this.state  = state;

        [MethodImpl(Inline)]
        public void Push(bit src)
        {
            state <<= 1;
            state |= (uint)src;
        }

        [MethodImpl(Inline)]
        public bit Pop()
        {
            var val = (bit)(state & 1);
            state >>= 1;
            return val;
        }
    }
}