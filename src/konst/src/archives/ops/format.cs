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

    partial struct Archives
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
            var records = span(src.Data);
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
        public static string format(FileKinds src)
        {
            var dst = text.build();
            format(src,dst);
            return dst.ToString();
        }

        [Op]
        public static void format(FileKinds src, StringBuilder dst)
        {
            dst.Append(Chars.LBracket);
            var count = src.Count;
            var reps = src.Reps;
            for(var i=0u; i<count; i++)
            {
                if(i != 0)
                {
                    dst.Append(Chars.Comma);
                    dst.Append(Chars.Space);
                }
                dst.Append(skip(reps,i).Name);
            }
            dst.Append(Chars.RBracket);
        }
    }
}