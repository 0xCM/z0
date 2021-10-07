//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public struct Packet
    {
        public uint Sequence;

        public uint DataType;

        public byte[] Payload;

        [MethodImpl(Inline)]
        public Packet(uint seq, uint dt, byte[] payload)
        {
            Sequence = seq;
            DataType = dt;
            Payload = payload;
        }
    }
}