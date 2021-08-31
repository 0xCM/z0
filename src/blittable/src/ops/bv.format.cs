//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        partial struct Operate
        {
            [Op]
            public static string vformat(in bv src)
            {
                var count = (int)src.Width;
                Span<char> buffer = stackalloc char[count];
                for(var i=0; i<count; i++)
                    seek(buffer,i) = src[i].ToChar();
                buffer.Reverse();
                return text.format(buffer);
            }
        }
    }
}