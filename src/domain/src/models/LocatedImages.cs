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
        public static int summarize(LocatedImages x)
            => 0;
        
        public readonly LocatedImage[] Data;

        [MethodImpl(Inline)]
        public LocatedImages(LocatedImage[] src)
            => Data = src;
        
        [MethodImpl(Inline)]
        public static implicit operator LocatedImages(LocatedImage[] src)
            => new LocatedImages(src);

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
    }

    partial class XTend
    {
        public static T? First<T>(this ReadOnlySpan<T> src, ValuePredicate<T> predicate)
            where T : struct
        {
            var count = src.Length;
            ref readonly var start = ref z.first(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var candidate = ref z.skip(start,i);
                if(predicate(candidate))
                    return candidate;
            }
            return null;
        }
    }
}