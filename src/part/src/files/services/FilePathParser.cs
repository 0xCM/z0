//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using IO = System.IO;

    using static Root;

    [ApiHost]
    public readonly struct FilePathParser : ITextParser2<FS.FilePath>
    {
        public static IParser2 service()
            => default(FilePathParser);

        [MethodImpl(Inline), Op]
        public static bool test(string src)
            => IO.Path.IsPathFullyQualified(src);

        [MethodImpl(Inline), Op]
        public static bool test(ReadOnlySpan<char> src)
            => IO.Path.IsPathFullyQualified(src);

        [Op]
        public bool Parse(string src, out FS.FilePath dst)
        {
            var success = false;
            if(test(src))
            {
                dst = FS.path(src);
                return true;
            }
            else
            {
                dst = FS.FilePath.Empty;
                return false;
            }
        }

        public ParseResult<FS.FilePath> Parse(string src)
        {
            if(Parse(src, out var dst))
                return ParseResult.parsed(src, dst);
            else
                return ParseResult.unparsed<FS.FilePath>(src);
        }
    }
}