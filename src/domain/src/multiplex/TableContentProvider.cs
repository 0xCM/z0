//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;

    using static Konst;
    using static z;

    public readonly struct TableContentProvider
    {
        public static IEnumerable<DocLibEntry> entries(Assembly src)
        {
            var names = ResExtractor.Service(src).ResourceNames;
            foreach(var name in names)
                yield return new DocLibEntry(name, Path.GetExtension(name));
        }

        public static TableContentProvider create(Assembly src)
            => new TableContentProvider(src);

        readonly Assembly Source;

        readonly ResExtractor Extractor;

        readonly TableSpan<DocLibEntry> _Entries;

        internal TableContentProvider(Assembly src)
        {
            Source = src;
            Extractor = ResExtractor.Service(src);
            _Entries = entries(src).Array();
        }

        public ReadOnlySpan<DocLibEntry> Entries
        {
            [MethodImpl(Inline)]
            get => _Entries.View;
        }

        [Op]
        ReadOnlySpan<ImageToken> SystemImages
        {
            get
            {
                var doc = structured("SystemImages");
                if(doc.RowCount != 0)
                {
                    var dst = sys.alloc<ImageToken>(doc.RowCount);
                    for(var i=0; i<doc.RowCount; i++)
                    {
                        ref readonly var row = ref doc[i];
                        if(row.CellCount >= 2)
                            dst[i] = new ImageToken(row[0], row[1]);
                    }
                    return dst;
                }
                return sys.empty<ImageToken>();
            }
        }

        /// <summary>
        /// Searches for an embedded document with a matching identifier and, if found,
        /// returns the first match; otherwise returns an empty document
        /// </summary>
        /// <param name="match">The resource identifier to match</param>
        AppResourceDoc structured(string match)
            => Extractor.MatchDocument(match);
    }
}