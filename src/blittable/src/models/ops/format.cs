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
            public static string format(in name64 src)
            {
                Span<char> dst = stackalloc char[name64.MaxLength];
                var count = src.Length;
                var data = src.Bytes;
                for(var i=0; i<count; i++)
                    seek(dst,i) = (char)skip(data,i);
                return text.format(slice(dst,0,count));
            }

            [Op]
            public static string format(in name128 src)
            {
                Span<char> dst = stackalloc char[name128.MaxLength];
                var count = src.Length;
                var data = src.Bytes;
                for(var i=0; i<count; i++)
                    seek(dst,i) = (char)skip(data,i);
                return text.format(slice(dst,0,count));
            }

            [Op]
            public static string format(in bv src)
            {
                var count = (int)src.Width;
                Span<char> buffer = stackalloc char[count];
                for(var i=0; i<count; i++)
                    seek(buffer,i) = src[i].ToChar();
                buffer.Reverse();
                return text.format(buffer);
            }

            public static string format<S,T>(in map<S,T> m)
                where S : unmanaged
                where T : unmanaged
            {
                const string Pattern = "{0} -> {1}";
                return string.Format(Pattern, m.Source, m.Target);
            }
        }
    }
}