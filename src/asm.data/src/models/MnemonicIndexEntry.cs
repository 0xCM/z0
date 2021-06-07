//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct MnemonicIndexEntry
    {
        public uint Sequence {get;}

        public Address16 Offset {get;}

        public ushort Size {get;}

        [MethodImpl(Inline)]
        public MnemonicIndexEntry(uint seq, Address16 offset, byte size)
        {
            Sequence = seq;
            Offset = offset;
            Size = size;
        }
    }
}