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
        partial class Render
        {
            [Op]
            public static string format(in text7 src)
            {
                Span<char> dst = stackalloc char[text7.MaxLength];
                var count = src.Length;
                var data = src.Bytes;
                for(var i=0; i<count; i++)
                    seek(dst, i) = (char)skip(data,i);
                return text.format(slice(dst,0,count));
            }

            [Op]
            public static string format(in text15 src)
            {
                Span<char> dst = stackalloc char[text15.MaxLength];
                var count = src.Length;
                var data = src.Bytes;
                for(var i=0; i<count; i++)
                    seek(dst,i) = (char)skip(data,i);
                return text.format(slice(dst,0,count));
            }
        }
    }
}