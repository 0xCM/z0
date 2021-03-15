//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    public readonly struct FileTypes
    {
        [Op]
        public static string format(FileType src)
        {
            var dst = text.buffer();
            render(src,dst);
            return dst.Emit();
        }

        [Op]
        public static void render(FileType src, ITextBuffer dst)
        {
            var extensions = text.bracket(src.Extensions.Delimit().Format());
            var content = src.ContentType.Format();
            dst.Append(text.bracket(src.Extensions.Delimit().Format()));
            dst.Append(" | ");
            dst.Append(src.ContentType.Format());
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
            var dst = text.buffer();
            render(src,dst);
            return dst.Emit();
        }

        readonly FileType[] Data;

        [MethodImpl(Inline)]
        public FileTypes(FileType[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ReadOnlySpan<FileType> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static implicit operator FileTypes(FileType[] src)
            => new FileTypes(src);
    }
}