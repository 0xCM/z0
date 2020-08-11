//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using Z0.Data;

    using static Konst;
    using static z;

    using F = ListedFileField;

    partial struct FileSystem
    {
        public static string format(in ListedFiles src)
        {
            var dst = text.build();
            render(src,dst);
            return dst.ToString();
        }

        public static void render(in ListedFiles src, Z0.FilePath dst)
        {
            var records = z.span(src.Data);
            var count = records.Length;
            var header = Table.header<F>();
            using var writer = dst.Writer();
            writer.WriteLine(header.HeaderText);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref src[i];
                writer.WriteLine(render(record));
            }    
        }

        public static void render(in ListedFiles src, StringBuilder dst)
        {
            var records = z.span(src.Data);
            var count = records.Length;
            var header = Table.header<F>();
            dst.AppendLine(header.HeaderText);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref src[i];
                dst.AppendLine(render(record));
            }    
        }
        
        public static string render(in ListedFile src)
            => text.format("{0,-10} | {1}", src.Index, src.Path);
    }
}