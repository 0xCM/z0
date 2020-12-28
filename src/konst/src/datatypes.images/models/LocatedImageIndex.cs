//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct LocatedImageIndex : IIndex<LocatedImage>
    {
        readonly Index<LocatedImage> Data;

        [MethodImpl(Inline)]
        public LocatedImageIndex(LocatedImage[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ref LocatedImage First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
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

        public LocatedImage[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static implicit operator LocatedImageIndex(LocatedImage[] src)
            => new LocatedImageIndex(src);

        [MethodImpl(Inline)]
        public static implicit operator LocatedImage[](LocatedImageIndex src)
            => src.Storage;
    }
}