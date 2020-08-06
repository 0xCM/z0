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
        public static ReadOnlySpan<ProcessImageSummary> summarize(LocatedImages src)
        {
            var count = src.Count;
            var images = src.View;
            var summaries = span<ProcessImageSummary>(count);
            var system = zdat.SystemImages;
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var summary = ref seek(summaries,i);
                var name = image.Name;
                var match = system.First((in SystemImageSymbol r) => r.Name == name);
                var symbolic = match.IsSome() ? match.Value.Identifier : image.Name.Replace("z0.", EmptyString);

                summary.ImageId = symbolic;
                summary.PartId = image.PartId;
                summary.EntryAddress = image.EndAddress;
                summary.BaseAddress = image.BaseAddress;
                summary.EndAddress = image.EndAddress;
                summary.Size = image.Size;
                if(i != 0)
                {
                    ref readonly var prior = ref skip(images, i - 1);
                    var gap = (ulong)(image.BaseAddress - prior.EndAddress);
                    summary.Gap = gap;
                }
            }

            return summaries;
        }        

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