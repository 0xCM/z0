//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Chars;

    /// <summary>
    /// Describes an embedded data resource
    /// </summary>
    public readonly struct BinaryRes
    {
        public StringRef Identifier {get;}

        public PartId Owner {get;}

        public ByteSize Size {get;}

        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        internal BinaryRes(PartId part, string id, ByteSize length, MemoryAddress address)
        {
            Owner = part;
            Identifier = id;
            Size = length;
            Address = address;
        }

        public bool IsEmpty
            => Address == 0;

        public string Uri
            => string.Concat("res", Colon, FSlash, FSlash, Owner.Format(), FSlash, Identifier);

        public unsafe ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => new ReadOnlySpan<byte>(Address.Pointer<byte>(), Size);
        }
    }
}