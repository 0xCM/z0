//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;
    using static z;

    partial struct FS
    {
        [Op]
        public static string format(ListedFiles src)
        {
            var dst = Z0.text.build();
            format(src,dst);
            return dst.ToString();
        }

        [MethodImpl(Inline), Op]
        public static string format(ListedFile src)
            => Z0.text.format("{0,-10} | {1}", src.Index, src.Path);

        [Op]
        public static void format(ListedFiles src, StringBuilder dst)
        {
            var records = src.View;
            var count = records.Length;
            var header = Table.header<ListedFileField>();
            dst.AppendLine(header.HeaderText);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref src[i];
                dst.AppendLine(format(record));
            }
        }

        [MethodImpl(Inline), Op]
        public static void format(ListedFiles src, Span<string> dst)
        {
            var count = src.Count;
            var listed = src.View;
            ref readonly var file = ref src[0];
            ref var formatted = ref first(dst);

            for(var i=0u; i<count; i++)
                seek(formatted,i) = format(skip(file,i));
        }
    }
}