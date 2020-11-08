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
        public utf8 Name {get;}

        public MemoryAddress Address {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        public ResourceDescriptor(utf8 name, MemoryAddress address, ByteSize size)
        {
            Name = name;
            Address = address;
            Size = size;
        }

        [MethodImpl(Inline)]
        public bool NameLike(string match)
            => Name.Format().Contains(match);

        [MethodImpl(Inline)]
        public int CompareTo(ResourceDescriptor src)
            => Address.CompareTo(src.Address);

        [MethodImpl(Inline)]
        public bool Equals(ResourceDescriptor src)
            => Address.Equals(src.Address);

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.PSx3, Address, Size, Name);

        public override string ToString()
            => Format();
    }
}