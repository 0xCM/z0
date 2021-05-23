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
            => new StringAddress(text.length(src) == 0 ? memory.address(Empty) : text.intern(src));

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
        public static implicit operator StringAddress(string src)
            => create(src);
    }
}