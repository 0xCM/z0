//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Blittable : IBlittable
    {
        readonly byte[] Data;

        public BitWidth Width {get;}

        [MethodImpl(Inline)]
        public Blittable(BitWidth width, byte[] data)
        {
            Width = width;
            Data = data;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}