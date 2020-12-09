//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    public readonly partial struct TextRules
    {
        partial struct Parse
        {

            [MethodImpl(Inline), Op]
            public static string right(string src, int desired)
            {
                var count = length(src);
                if (count == 0)
                    return EmptyString;

                var data = span(src);
                var actual = count < desired ? count : desired;

                Span<char> dst = stackalloc char[actual];
                for (var i=0u; i<count; i++)
                    seek(dst,i) = skip(data, count - actual + i);

                return new string(dst);
            }
        }
    }
}