//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public ref struct BitStack
    {
        ulong state;

        [MethodImpl(Inline)]
        public static BitStack Init(ulong state = 0)
            => new BitStack(state);

        [MethodImpl(Inline)]
        BitStack(ulong state)
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

        public string Format()
            => state.ToBitString().Format();
    }

}