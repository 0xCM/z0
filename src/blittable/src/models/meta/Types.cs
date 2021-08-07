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
    using static AsciCode;
    using static BlittableKind;

    using K = BlittableKind;

    partial struct Blit
    {
        [ApiHost]
        public readonly partial struct Types
        {
            const byte TypeKindCount = 13;

            [MethodImpl(Inline), Op]
            static Blit.TypeIndicator indicator(BlittableKind src)
                => new Blit.TypeIndicator(skip(IndicatorSymbols,(byte)src));

            [MethodImpl(Inline), Op]
            public static BlittableKind typekind(byte index)
                => skip(TypeKinds, index);

            [MethodImpl(Inline), Op]
            public static DataType type(BlittableKind kind, BitWidth content, BitWidth storage)
                => new DataType(kind, content, storage);

            // define i8 @v8i16(<8 x i16> %a, <8 x i16> %b, <8 x i16> %c, <8 x i16> %d)

            [MethodImpl(Inline), Op]
            public static DataType v8(uint n)
                => type(BlittableKind.Vector, n*8, n*8);

            [MethodImpl(Inline), Op]
            public static DataType v16(uint n)
                => type(BlittableKind.Vector, n*16, n*16);

            [MethodImpl(Inline), Op]
            public static DataType v32(uint n)
                => type(BlittableKind.Vector, n*32, n*32);

            [MethodImpl(Inline), Op]
            public static DataType v64(uint n)
                => type(BlittableKind.Vector, n*64, n*64);

            [MethodImpl(Inline), Op]
            public static DataType v128(uint n)
                => type(BlittableKind.Vector, n*128, n*128);

            [MethodImpl(Inline), Op]
            public static DataType v256(uint n)
                => type(BlittableKind.Vector, n*256, n*256);

            [MethodImpl(Inline), Op]
            public static DataType v512(uint n)
                => type(BlittableKind.Vector, n*512, n*512);

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
                    case BlittableKind.Cube:
                    break;
                    case BlittableKind.Name:
                    break;
                    default:
                    break;
                }

                return text.format(slice(dst,0,i));
            }

            static ReadOnlySpan<byte> SymbolIndex
                => new byte[TypeKindCount*2]{
                    (byte)Question,0,
                    (byte)u,1,
                    (byte)i,2,
                    (byte)f,3,
                    (byte)c,4,
                    (byte)e,5,
                    (byte)v,6,
                    (byte)a,7,
                    (byte)t,8,
                    (byte)d,9,
                    (byte)s,10,
                    (byte)z,11,
                    (byte)q,12,
                    };

            static ReadOnlySpan<AsciCode> IndicatorSymbols
                => new AsciCode[TypeKindCount]{
                    Question,
                    u,
                    i,
                    f,
                    c,
                    e,
                    v,
                    a,
                    t,
                    d,
                    s,
                    z,
                    q,
                    };

            static ReadOnlySpan<BlittableKind> TypeKinds
                => new BlittableKind[TypeKindCount]{
                    K.Unknown,
                    K.Unsigned,
                    K.Signed,
                    K.Float,
                    K.Char,
                    K.Enum,
                    K.Vector,
                    K.Array,
                    K.Tensor,
                    K.Domain,
                    K.Sequence,
                    K.Cube,
                    K.Name,
                    };
        }

    }
}