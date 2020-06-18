//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct MemorySlot
    {        
        readonly MemRef Ref;

        [MethodImpl(Inline)]
        public MemorySlot(MemRef src)
            => Ref = src;

        [MethodImpl(Inline)]
        public MemorySlot(MemoryAddress address, ByteSize size)
            => Ref = new MemRef(address,size);

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Ref.Address;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Ref.Length;
        }
    }
}