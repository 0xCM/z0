//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct ClrIndex
    {
        public const string PatternText = "{0,-60} | {1,-16}";

        [MethodImpl(Inline)]
        static string[] labels(MetadataOffset src)
            => typeof(MetadataOffset).DeclaredInstanceFields().Select(x => x.Name);

        [MethodImpl(Inline)]
        static string format(MetadataOffset src)
            => text.format(PatternText, src.Name, src.Value);

        public static void save(ReadOnlySpan<MetadataOffset> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var l = labels(default(MetadataOffset));
            writer.WriteLine(text.format(PatternText, l[0], l[1]));
            for(var i=0u; i<src.Length; i++)
                writer.WriteLine(ClrIndex.format(skip(src,i)));
        }

        public readonly struct MetadataOffset
        {
            public readonly string Name;

            public readonly ulong Value;

            [MethodImpl(Inline)]
            public MetadataOffset(string name, ulong address)
            {
                Name = name;
                Value  = address;
            }
        }
    }
}