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

    public struct Blittable<T> : IBlittable<T>
        where T : unmanaged
    {
        T Storage;

        public BitWidth Width {get;}

        [MethodImpl(Inline)]
        public Blittable(BitWidth width, T data)
        {
            Width = width;
            Storage = data;
        }

        public T Data
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => bytes(Storage);
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => bytes(Storage);
        }
    }
}