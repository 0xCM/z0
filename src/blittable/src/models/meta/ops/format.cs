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

    partial struct Blit
    {
        partial struct Types
        {
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