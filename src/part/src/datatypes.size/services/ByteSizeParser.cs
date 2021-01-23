//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static root;

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
                return root.unparsed<ByteSize>(src,e);
            }
        }
    }
}