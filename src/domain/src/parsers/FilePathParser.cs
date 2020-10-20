//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using IO = System.IO;

    using static Konst;

    [ApiHost(ApiNames.FilePathParser, true), ParserHost]
    public readonly struct FilePathParser : ParseFunctions.ICanonical<string,FS.FilePath>
    {
        public static IParseFunction service()
            => default(FilePathParser);

        [MethodImpl(Inline), Op]
        public static bool test(string src)
            => IO.Path.IsPathFullyQualified(src);

        [MethodImpl(Inline), Op]
        public static bool test(ReadOnlySpan<char> src)
            => IO.Path.IsPathFullyQualified(src);

        [Op]
        public static bool parse(string src, out FS.FilePath dst)
        {
            var success = false;
            if(test(src))
            {
                dst = FS.path(src);
                success = true;
            }
            else
                dst = FS.FilePath.Empty;
            return success;
        }

        public bool Parse(in string src, out FS.FilePath dst)
            => parse(src, out dst);

    }
}