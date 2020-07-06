//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct MemSlot
    {        
        readonly MemRef Ref;

        [MethodImpl(Inline)]
        public MemSlot(in MemRef src)
            => Ref = src;

        [MethodImpl(Inline)]
        public MemSlot(MemoryAddress address, uint size)
            => Ref = new MemRef(address,size);

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Ref.Address;
        }

        public uint DataSize
        {
            [MethodImpl(Inline)]
            get => Ref.DataSize;
        }
    }
}