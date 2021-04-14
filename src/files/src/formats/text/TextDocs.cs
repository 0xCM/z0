//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct TextDocs
    {
        public static ParseResult<string,TextDoc> parse(FS.FilePath src, TextDocFormat? format = null)
        {
            if(!src.Exists)
            {
                term.error($"No such file {src}");
                return root.unparsed(src.Name.Format(), default(TextDoc));
            };

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