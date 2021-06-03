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

    public readonly struct ApiRes
    {
        public ApiResAccessor Accessor {get;}

        public MemoryAddress Address {get;}

        public readonly uint Size {get;}

        [MethodImpl(Inline)]
        public ApiRes(ApiResAccessor accessor, MemoryAddress address, uint size)
        {
            Accessor = accessor;
            Address = address;
            Size = size;
        }

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => cover<byte>(Address, Size);
        }
    }
}