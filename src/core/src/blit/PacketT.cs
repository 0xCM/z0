//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct Packet<T>
        where T : unmanaged
    {
        public uint Sequence;

        public T[] Payload;

        [MethodImpl(Inline)]
        public Packet(uint seq, T[] payload)
        {
            Sequence = seq;
            Payload = payload;
        }
    }
}