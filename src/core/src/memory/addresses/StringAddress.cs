//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = TextTools;

    public readonly struct StringAddress : IAddressable
    {
        internal const string Empty = "<empty>";

        [MethodImpl(Inline)]
        public static StringAddress create(string src)
            => api.address(src);

        [MethodImpl(Inline)]
        public static StringAddress resource(string src)
            => api.resource(src);

        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        internal StringAddress(MemoryAddress location)
        {
            Address = location;
        }

        public uint Length
        {
            [MethodImpl(Inline)]
            get => api.length(this);
        }

        [MethodImpl(Inline)]
        public uint Render(ref uint i, Span<char> dst)
            => api.render(this, ref i, dst);

        [MethodImpl(Inline)]
        public unsafe string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(StringAddress src)
            => Address.Equals(src.Address);

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(StringAddress src)
            => src.Address;

        [MethodImpl(Inline)]
        public static explicit operator StringAddress(ulong src)
            => new StringAddress(src);

        [MethodImpl(Inline)]
        public static explicit operator StringAddress(MemoryAddress src)
            => new StringAddress(src);

        [MethodImpl(Inline)]
        public static implicit operator StringAddress(ResourceAddress src)
            => new StringAddress(src.Location);

        [MethodImpl(Inline)]
        public static implicit operator StringAddress(string src)
            => create(src);

        [MethodImpl(Inline)]
        public static implicit operator StringAddress(Name src)
            => create(src.Content);
    }
}