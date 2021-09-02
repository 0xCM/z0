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

    [Blittable(SZ)]
    public unsafe readonly struct StringAddress : IAddressable
    {
        public const uint SZ = MemoryAddress.SZ;

        [MethodImpl(Inline), Op]
        public static unsafe string format(StringAddress src)
            => new string(src.Address.Pointer<char>());

        [MethodImpl(Inline), Op]
        public static unsafe string format<N>(StringAddress<N> src)
            where N : unmanaged, ITypeNat
                => new string(src.Address.Pointer<char>());

        [MethodImpl(Inline), Op]
        public static unsafe ref char first(StringAddress src)
            => ref @ref(src.Address.Pointer<char>());

        [MethodImpl(Inline), Op]
        public static uint length(StringAddress src)
        {
            ref var c = ref first(src);
            var counter = 0u;
            while(c != 0)
                c = seek(c, counter++);
            return counter;
        }

        [MethodImpl(Inline)]
        public static uint render<N>(StringAddress<N> src, ref uint i, Span<char> dst)
            where N : unmanaged, ITypeNat
        {
            ref var c = ref first(src.Source);
            var n = src.Length;
            for(var j=0; j<n; j++)
                seek(dst,i++) = skip(c,j);
            return n;
        }

        [MethodImpl(Inline), Op]
        public static uint render(StringAddress src, ref uint i, Span<char> dst)
        {
            var i0=i;
            ref var c = ref first(src);
            var j=0u;
            while(c != 0 && i < dst.Length)
                seek(dst, i++) = skip(c, j++);
            return j-1;
        }

        [MethodImpl(Inline)]
        public static StringAddress<N> natural<N>(string src)
            where N : unmanaged, ITypeNat
        {
            if(src.Length >= Typed.nat32i<N>())
                return new StringAddress<N>(resource(src));
            else
                return default;
        }

        [MethodImpl(Inline), Op]
        public static StringAddress resource(string src)
            => new StringAddress(core.address(src));

        [MethodImpl(Inline), Op]
        public static StringAddress from(ReadOnlySpan<char> src)
            => new StringAddress(core.address(src));

        [MethodImpl(Inline), Op]
        public static StringAddress from<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => new StringAddress(core.address(src));

        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        public StringAddress(MemoryAddress location)
        {
            Address = location;
        }

        public ReadOnlySpan<char> Chars
        {
            [MethodImpl(Inline)]
            get => cover(Address.Pointer<char>(), Length);
        }

        public uint Length
        {
            [MethodImpl(Inline)]
            get => length(this);
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
            => resource(src);

        [MethodImpl(Inline)]
        public static implicit operator StringAddress(Name src)
            => resource(src.Content);
    }
}