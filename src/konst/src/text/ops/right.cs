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

    partial class text
    {
        [MethodImpl(Inline), Op]
        public static string right(string input, int desired)
        {
            if (empty(input))
                return input;

            var cIn = input.Length;
            var src = span(input);
            var actual = cIn < desired ? cIn : desired;

            Span<char> dst = stackalloc char[actual];
            for (var i=0u; i<cIn; i++)
                seek(dst,i) = skip(src, cIn - actual + i);

            return new string(dst);
        }
    }
}