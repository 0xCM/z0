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
    using static BlittableKind;
    using static Blit.Types;

    partial struct Blit
    {
        partial class Render
        {
            [Op]
            public static string format(TypeIndicator src)
            {
                Span<char> dst = stackalloc char[2];
                var c1 = (char)((byte)src.Data >> 8);
                seek(dst,0) = (char)((byte)src.Data);
                seek(dst,1) = c1;
                var length = 1 + (c1 != 0 ? 1 : 0);
                return text.format(slice(dst,0,length));
            }

            [Op]
            public static string format(DataType src)
            {
                const byte Max = 32;
                var i=0u;
                Span<char> dst = stackalloc char[Max];
                seek(dst,i++) = indicator(src.Kind);
                switch(src.Kind)
                {
                    case Unsigned:
                    case Signed:
                    case Float:
                    text.copy(src.ContentWidth.ToString(), ref i, dst);
                    break;
                    case BlittableKind.Char:
                    break;
                    case BlittableKind.Enum:
                    break;
                    case Vector:
                    break;
                    case BlittableKind.Array:
                    break;
                    case BlittableKind.Tensor:
                    break;
                    case BlittableKind.Domain:
                    break;
                    case BlittableKind.Sequence:
                    break;
                    case BlittableKind.Grid:
                    break;
                    case BlittableKind.Name:
                    break;
                    default:
                    break;
                }

                return text.format(slice(dst,0,i));
            }
        }
    }
}