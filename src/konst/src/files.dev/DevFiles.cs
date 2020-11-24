//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct DevFiles
    {
        [MethodImpl(Inline), Op]
        public static IncludePath include(FS.FolderPath src)
            => new IncludePath(src);

        [Op]
        public static IncludePaths includes(params FS.FolderPath[] src)
            => new IncludePaths(map(src,include));

        [MethodImpl(Inline), Op]
        public static IncludePaths includes(params IncludePath[] src)
            => new IncludePaths(src);

        [Op]
        public static string format(IncludePath src)
            => src.Path.Format(PathSeparator.BS);

        [Op]
        public static string format(IncludeFile src)
            => src.Path.Format(PathSeparator.BS);

        [Op]
        public static void render(IncludePaths src, ITextBuffer dst)
        {
            var files = @readonly(src.Storage);
            var count = files.Length;
            for(var i=0; i<count; i++)
            {
                dst.Append(format(skip(files,i)));
                if(i != count - 1)
                    dst.Append(Chars.Semicolon);
            }
        }

        [Op]
        public static string format(IncludePaths src)
        {
            var dst = Buffers.text();
            render(src,dst);
            return dst.Emit();
        }
    }
}