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
    using static TextTools;

    using api = TextTools;

    public readonly struct StringAddress : IAddressable
    {
        [MethodImpl(Inline), Op]
        public static uint length(StringAddress src)
        {
            ref var c = ref firstchar(src);
            var counter = 0u;
            while(c != 0)
                c = seek(c, counter++);
            return counter - 1;
        }

        [MethodImpl(Inline), Op]
        public static uint render(StringAddress src, ref uint i, Span<char> dst)
        {
            var i0=i;
            ref var c = ref firstchar(src);
            var j=0u;
            while(c != 0 && i < dst.Length)
                seek(dst, i++) = skip(c, j++);
            return j-1;
        }

        [MethodImpl(Inline), Op]
        public static StringAddress resource(string src)
            => new StringAddress(core.address(src));

        internal const string EmptyMarker = "<empty>";

        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        internal StringAddress(MemoryAddress location)
        {
            Address = location;
        }

        public uint Length
        {
            [MethodImpl(Inline)]
            get => length(this);
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => Address.Hash;
        }

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => Address.IsNonZero;
        }

        [MethodImpl(Inline)]
        public uint Render(ref uint i, Span<char> dst)
            => render(this, ref i, dst);

        [MethodImpl(Inline)]
        public unsafe string Format()
            => format(this);

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
            => api.intern(src);

        [MethodImpl(Inline)]
        public static implicit operator StringAddress(Name src)
            => api.intern(src.Content);
    }
}