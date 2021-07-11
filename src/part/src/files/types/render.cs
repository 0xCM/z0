//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class FileTypes
    {
        [Op]
        public static string format(FileType src)
        {
            var dst = text.buffer();
            render(src,dst);
            return dst.Emit();
        }

        [Op]
        public static string format(Index<FileType> src)
        {
            var dst = text.buffer();
            render(src,dst);
            return dst.Emit();
        }

        [Op]
        public static void render(FileType src, ITextBuffer dst)
        {
            if(src.IsNonEmpty)
            {
                dst.Append(src.FileKind.Format());
                dst.Append(Chars.Colon);
                dst.Append(string.Join(Chars.Semicolon, src.FileExt));
            }
        }

        [Op]
        public static void render(Index<FileType> src, ITextBuffer dst)
        {
            var count = src.Count;
            var view = src.View;
            for(var i=0; i<count; i++)
                dst.AppendLine(format(skip(src,i)));
        }
    }
}