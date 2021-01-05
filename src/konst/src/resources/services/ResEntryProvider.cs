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

    using static Part;

    public readonly struct ResEntryProvider : IResEntryProvider
    {
        public static ResEntryProvider create(Assembly src)
            => new ResEntryProvider(src);

        static IEnumerable<DocLibEntry> entries(Assembly src)
        {
            var names = ResExtractor.Service(src).ResourceNames;
            foreach(var name in names)
                yield return new DocLibEntry(name, Path.GetExtension(name));
        }

        readonly Assembly Source;

        readonly ResExtractor Extractor;

        readonly Index<DocLibEntry> _Entries;

        internal ResEntryProvider(Assembly src)
        {
            Source = src;
            Extractor = ResExtractor.Service(src);
            _Entries = entries(src).Array();
        }


        public Index<DocLibEntry> Entries
        {
            [MethodImpl(Inline)]
            get => _Entries;
        }
    }
}