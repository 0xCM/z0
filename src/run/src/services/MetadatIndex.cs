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
    public readonly struct MetadataIndex
    {
        [MethodImpl(Inline), Op]
        public static FieldInfo[] fields(ResourceIndex src)
            => typeof(ResourceIndex).DeclaredInstanceFields();

        [MethodImpl(Inline), Op]
        public static string[] labels(ResourceIndex src)
            => typeof(ResourceIndex).DeclaredInstanceFields().Select(x => x.Name);

        [MethodImpl(Inline), Op]
        public static string format(ResourceIndex src)
            => text.format(src.FormatPattern, src.Name, src.Address);

        [MethodImpl(Inline), Op]
        public static string headers(ResourceIndex src)
        {
            var f = fields(src);
            return text.format(ResourceIndex.PatternText, f[0].Name, f[1].Name);
        }

        public readonly struct ResourceIndex
        {
            public const string PatternText = "{0,-60} | {1,-16}";

            public string FormatPattern
                => PatternText;

            public readonly string Name;

            public readonly MemoryAddress Address;

            [MethodImpl(Inline)]
            public ResourceIndex(string name, MemoryAddress address)
            {
                Name = name;
                Address  = address;
            }
        }

        public static void save(ReadOnlySpan<ResourceIndex> src, FilePath dst)
        {
            using var writer = dst.Writer();
            var l = labels(default(ResourceIndex));
            writer.WriteLine(text.format(ResourceIndex.PatternText, l[0], l[1]));
            for(var i=0u; i<src.Length; i++)
                writer.WriteLine(MetadataIndex.format(skip(src,i)));
        }
    }
}