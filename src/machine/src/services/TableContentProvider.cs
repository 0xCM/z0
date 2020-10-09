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

    public readonly struct TableContentProvider : IContentProvider
    {
        public static TableContentProvider create(Assembly src)
            => new TableContentProvider(src);

        readonly Assembly Source;

        readonly ResExtractor Extractor;

        readonly TableSpan<DocLibEntry> _Entries;

        internal TableContentProvider(Assembly src)
        {
            Source = src;
            Extractor = ResExtractor.Service(src);
            _Entries = Provided.Array();
        }

        public ReadOnlySpan<DocLibEntry> Entries
        {
            [MethodImpl(Inline)]
            get => _Entries.View;
        }

        public IEnumerable<DocLibEntry> Provided
        {
            get
            {
                var names = Extractor.ResourceNames;
                foreach(var name in names)
                {
                    yield return new DocLibEntry(name, Path.GetExtension(name));
                }
            }
        }


        [Op]
        ReadOnlySpan<ImageToken> SystemImages
        {
            get
            {
                var doc = structured(nameof(SystemImages));
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