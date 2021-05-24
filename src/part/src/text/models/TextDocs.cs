//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static core;

    [ApiHost]
    public readonly struct TextDocs
    {
        public static uint header(string src, char delimiter, Span<string> dst)
        {
            var count = 0u;
            if(text.nonempty(src))
            {
                var parts = @readonly(src.SplitClean(delimiter));
                count = (uint)parts.Length;
                if(count != 0)
                {
                    for(var i=0; i<count; i++)
                        seek(dst,i) = skip(parts,i);
                }
            }
            return count;
        }

        public static ReadOnlySpan<string> header(string src, char delimiter)
        {
            var dst = Span<string>.Empty;
            if(text.nonempty(src))
            {
                var parts = @readonly(src.SplitClean(delimiter));
                var count = (uint)parts.Length;
                dst = span<string>(count);
                for(var i=0; i<count; i++)
                    seek(dst,i) = skip(parts,i);
            }
            return dst;
        }

        public static ParseResult<string,TextDoc> parse(FS.FilePath src, TextDocFormat? format = null)
        {
            using var reader = src.Reader();
            return TextDoc.parse(reader, format).Select(doc => root.parsed(src.Name.Format(), doc)).Value;
        }

        public static Outcome parse(FS.FilePath src, out TextDoc dst)
        {
            dst = TextDoc.Empty;
            if(!src.Exists)
                return (false, $"No such file {src}");

            using var reader = src.Reader();
            var attempt =  TextDoc.parse(reader);
            if(attempt)
            {
                dst = attempt.Value;
                return true;
            }
            else
            {
                return (false, attempt.Message?.ToString());
            }
        }
    }
}