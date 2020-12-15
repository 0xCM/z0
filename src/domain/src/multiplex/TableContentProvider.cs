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

    public readonly struct TableContentProvider
    {
        public static TableContentProvider create(Assembly src)
            => new TableContentProvider(src);

        static IEnumerable<DocLibEntry> entries(Assembly src)
        {
            var names = ResExtractor.Service(src).ResourceNames;
            foreach(var name in names)
                yield return new DocLibEntry(name, Path.GetExtension(name));
        }

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
    }
}