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
        public MemSlot(MemRef src)
            => Ref = src;

        [MethodImpl(Inline)]
        public MemSlot(MemoryAddress address, ByteSize size)
            => Ref = new MemRef(address,size);

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Ref.Location;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Ref.Length;
        }
    }
}