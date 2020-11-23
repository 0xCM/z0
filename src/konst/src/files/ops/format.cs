//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct FS
    {
        [Op]
        public static string format(ListedFiles src)
        {
            var dst = text.build();
            format(src,dst);
            return dst.ToString();
        }

        [MethodImpl(Inline), Op]
        public static string format(ListedFile src)
            => text.format("{0,-10} | {1}", src.Index, src.Path);

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

        [Op]
        public static string format(FileType src)
        {
            var dst = Buffers.text();
            render(src,dst);
            return dst.Emit();
        }

        [Op]
        public static void render(FileType src, ITextBuffer dst)
        {
            var extensions = text.bracket(src.Extensions.Delimited().Format());
            var content = src.ContentKind.Format();
            dst.Append(text.bracket(src.Extensions.Delimited().Format()));
            dst.Append(" | ");
            dst.Append(src.ContentKind.Format());
        }

        [Op]
        public static void render(FileTypes src, ITextBuffer dst)
        {
            var count = src.Count;
            var view = src.View;
            for(var i=0; i<count; i++)
            {
                render(skip(view,i), dst);
                dst.AppendLine();
            }
        }

        [Op]
        public static string format(FileTypes src)
        {
            var dst = Buffers.text();
            render(src,dst);
            return dst.Emit();
        }
    }
}