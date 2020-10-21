//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ResourceDescriptor : IComparable<ResourceDescriptor>, IEquatable<ResourceDescriptor>, ITextual, IAddressable
    {
        public StringRef Name {get;}

        public MemoryAddress Address {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        public ResourceDescriptor(string name, MemoryAddress address, ByteSize size)
        {
            Name = name;
            Address = address;
            Size = size;
        }

        [MethodImpl(Inline)]
        public int CompareTo(ResourceDescriptor src)
            => Address.CompareTo(src.Address);

        [MethodImpl(Inline)]
        public bool Equals(ResourceDescriptor src)
            => Address.Equals(src.Address);

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(Address, Size, Name);

        public override string ToString()
            => Format();
    }
}