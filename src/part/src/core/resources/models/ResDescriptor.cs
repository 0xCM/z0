//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes an embedded resource
    /// </summary>
    public readonly struct ResDescriptor : IDataTypeComparable<ResDescriptor>, IAddressable
    {
        /// <summary>
        /// Defines a <see cref='ResDescriptor'/>
        /// </summary>
        /// <param name="name">The resource name</param>
        /// <param name="address">The memory location at which the resource content begins</param>
        /// <param name="size">The size of the resource, in bytes</param>
        [MethodImpl(Inline), Op]
        public static ResDescriptor define(Name name, MemoryAddress address, ByteSize size)
            => new ResDescriptor(name, address, size);

        public Name Name {get;}

        public MemoryAddress Address {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        public ResDescriptor(Name name, MemoryAddress address, ByteSize size)
        {
            Name = name;
            Address = address;
            Size = size;
        }

        public MemSeg Segment
        {
            [MethodImpl(Inline)]
            get => new MemSeg(Address, Size);
        }

        [MethodImpl(Inline)]
        public bool NameLike(string match)
            => Name.Format().Contains(match);

        [MethodImpl(Inline)]
        public int CompareTo(ResDescriptor src)
            => Address.CompareTo(src.Address);

        [MethodImpl(Inline)]
        public bool Equals(ResDescriptor src)
            => Address.Equals(src.Address);

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.PSx3, Address, Size, Name);

        public override string ToString()
            => Format();

        public static ResDescriptor Empty
            => new ResDescriptor(Name.Empty, 0, 0);
    }
}