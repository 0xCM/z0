//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Addressing
    {
        public static Space space(MemoryAddress lower, MemoryAddress upper, AddressSize adsz)
            => new Space(lower,upper, adsz);

        public readonly struct Space<T>
            where T : unmanaged
        {

        }

        public readonly struct Space
        {
            public MemoryAddress LowerBound {get;}

            public MemoryAddress UpperBound {get;}

            public AddressSize AddressSize {get;}

            [MethodImpl(Inline)]
            public Space(MemoryAddress @base, MemoryAddress last, AddressSize size)
            {
                LowerBound = @base;
                UpperBound = last;
                AddressSize = size;
            }

            public ByteSize Range
            {
                [MethodImpl(Inline)]
                get => (ulong)UpperBound - (ulong)LowerBound;
            }
        }
    }
}