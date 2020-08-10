//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;


    using static Konst;
    using static z;

    partial struct Tables
    {
        [MethodImpl(Inline), Op]
        static void fill(in LocatedImage src,ref ProcessImageSummary dst)
        {
            dst.PartId = src.PartId;
            dst.EntryAddress = src.EndAddress;
            dst.BaseAddress = src.BaseAddress;
            dst.EndAddress = src.EndAddress;
            dst.Size = src.Size;
        }
        
        [Op]
        public static ReadOnlySpan<ProcessImageSummary> summarize(LocatedImages src)
        {
            var count = src.Count;
            var images = src.View;
            var summaries = span<ProcessImageSummary>(count);
            var system = SystemImages;
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var summary = ref seek(summaries,i);
                var name = image.Name;
                var match = system.First((in SystemImageSymbol r) => r.Name == name);
                summary.ImageId = match.IsSome() ? match.Value.Identifier : image.Name.Replace("z0.", EmptyString);
                fill(image, ref summary);

                if(i != 0)
                {
                    ref readonly var prior = ref skip(images, i - 1);
                    var gap = (ulong)(image.BaseAddress - prior.EndAddress);
                    summary.Gap = gap;
                }
            }

            return summaries;
        }        

        [Op]
        public static ReadOnlySpan<SystemImageSymbol> SystemImages
        {
            get
            {
                var doc = structured(nameof(SystemImages));
                if(doc.RowCount != 0)
                {
                    var dst = sys.alloc<SystemImageSymbol>(doc.RowCount);
                    for(var i=0; i<doc.RowCount; i++)
                    {
                        ref readonly var row = ref doc[i];
                        if(row.CellCount >= 2)
                            dst[i] = new SystemImageSymbol(row[0], row[1]);                        
                    }
                    return dst;
                }
                return sys.empty<SystemImageSymbol>();
            }
        }

        static ResExtractor Extractor
            => ResExtractor.Service(typeof(Z0.Parts.Tables).Assembly);

        /// <summary>
        /// Searches for an embedded document with a matching identifier and, if found,
        /// returns the first match; otherwise returns an empty document
        /// </summary>
        /// <param name="match">The resource identifier to match</param>
        public static AppResourceDoc structured(string match)
            => Extractor.MatcDocument(match);        
    }    
}