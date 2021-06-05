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

    public readonly struct StringAddress : IAddressable
    {
        const string Empty = "<empty>";

        [MethodImpl(Inline)]
        public static StringAddress create(string src)
            => new StringAddress(src?.Length == 0 ? address(Empty) : address(string.Intern(src)));

        [MethodImpl(Inline)]
        public static StringAddress resource(string src)
            => new StringAddress(address(src));

        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        internal StringAddress(MemoryAddress location)
        {
            Address = location;
        }

        unsafe ref char FirstChar
        {
            [MethodImpl(Inline)]
            get => ref @ref(Address.Pointer<char>());
        }

        public uint Length()
        {
            ref var start = ref FirstChar;
            var counter = 0u;
            while(start != 0)
                counter++;
            return counter;
        }

        public unsafe string Format()
            => new string(gptr(FirstChar));

        public override string ToString()
            => Format();

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