//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Root;
    using static core;
    using static PeRecords;

    partial class PeTableReader
    {
        [MethodImpl(Inline), Op]
        public static Address32 offset(MetadataReader reader, UserStringHandle handle)
            => (Address32)reader.GetHeapOffset(handle);

        public const string OffsetPatternText = "{0,-60} | {1,-16}";

        [MethodImpl(Inline)]
        static string[] labels(FieldOffset src)
            => typeof(FieldOffset).DeclaredInstanceFields().Select(x => x.Name);

        [MethodImpl(Inline)]
        static string format(FieldOffset src)
            => text.format(OffsetPatternText, src.Name, src.Value);

        [Op]
        public static void save(ReadOnlySpan<FieldOffset> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var l = labels(default(FieldOffset));
            writer.WriteLine(text.format(OffsetPatternText, l[0], l[1]));
            for(var i=0u; i<src.Length; i++)
                writer.WriteLine(format(skip(src,i)));
        }
    }
}