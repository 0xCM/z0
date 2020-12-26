//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static corefunc;

    [Formatter]
    readonly struct ByteSizeFormatter : ITextFormatter<ByteSize>
    {
        public string Format(ByteSize src)
            => src.Content == 0 ? "0" : src.Content.ToString("#,#");
    }

    [Parser]
    readonly struct ByteSizeParser : ITextParser<ByteSize>
    {
        public ParseResult<ByteSize> Parse(string src)
        {
            try
            {
                if(ulong.TryParse(src, out var dst))
                    return (src,dst);
                else
                    return unparsed<ByteSize>(src);
            }
            catch(Exception e)
            {
                return corefunc.unparsed<ByteSize>(src,e);
            }
        }
    }
}