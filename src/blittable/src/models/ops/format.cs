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
            public static string format<T>(in v1<T> src)
                where T : unmanaged
                    => string.Format(RP.V1, src[0]);

            public static string format<T>(in v2<T> src)
                where T : unmanaged
                    => string.Format(RP.V2, src[0], src[1]);

            public static string format<T>(in v3<T> src)
                where T : unmanaged
                    => string.Format(RP.V3,
                        src[0], src[1], src[2]);

            public static string format<T>(in v4<T> src)
                where T : unmanaged
                    => string.Format(RP.V4,
                        src[0], src[1], src[2], src[3]);

            public static string format<T>(in v8<T> src)
                where T : unmanaged
                    => string.Format(RP.V8,
                        src[0], src[1], src[2], src[3], src[4], src[5], src[6], src[7]);

            public static string format<T>(in v16<T> src)
                where T : unmanaged
                    => string.Format(RP.V16,
                        src[0],  src[1],  src[2],  src[3],  src[4],  src[5],  src[6],  src[7],
                        src[8],  src[9],  src[10], src[11], src[12], src[13], src[14], src[15]
                        );

            public static string format<T>(in v32<T> src)
                where T : unmanaged
                    => string.Format(RP.V32,
                        src[0],  src[1],  src[2],  src[3],  src[4],  src[5],  src[6],  src[7],  src[8], src[9],
                        src[10], src[11], src[12], src[13], src[14], src[15], src[16], src[17], src[18], src[19],
                        src[20], src[21], src[22], src[23], src[24], src[25], src[26], src[27], src[28], src[29],
                        src[30], src[31]
                        );

            public static string format<T>(in v64<T> src)
                where T : unmanaged
                    => string.Format(RP.V32,
                        src[0],  src[1],  src[2],  src[3],  src[4],  src[5],  src[6],  src[7],  src[8], src[9],
                        src[10], src[11], src[12], src[13], src[14], src[15], src[16], src[17], src[18], src[19],
                        src[20], src[21], src[22], src[23], src[24], src[25], src[26], src[27], src[28], src[29],
                        src[30], src[31], src[32], src[33], src[34], src[35], src[36], src[37], src[38], src[39],
                        src[40], src[41], src[42], src[43], src[44], src[45], src[46], src[47], src[48], src[49],
                        src[50], src[51], src[52], src[53], src[54], src[55], src[56], src[57], src[58], src[59],
                        src[60], src[61], src[62], src[63]
                        );


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