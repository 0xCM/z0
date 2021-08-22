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

            public static string format<N,T>(in vector<N,T> src)
                where T : unmanaged
                where N : unmanaged, ITypeNat
            {
                var cells = src.Cells;
                var count = cells.Length;
                var buffer = text.buffer();
                var last = cells.Length - 1;
                for(var i=0; i<count; i++)
                {
                    ref readonly var cell = ref skip(cells,i);
                    var fmt = string.Format("{0}", cell).Trim();
                    if(nonempty(fmt))
                    {
                        buffer.Append(fmt);
                        if(i != last)
                            buffer.Append(Chars.Comma);

                    }
                    else
                        break;
                }
                return buffer.Emit();
            }
        }
    }
}