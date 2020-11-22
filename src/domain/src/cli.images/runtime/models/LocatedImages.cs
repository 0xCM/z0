//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct LocatedImages
    {
        public readonly LocatedImage[] Data;

        [MethodImpl(Inline)]
        public LocatedImages(LocatedImage[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ReadOnlySpan<LocatedImage> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<LocatedImage> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static implicit operator LocatedImages(LocatedImage[] src)
            => new LocatedImages(src);
    }
}