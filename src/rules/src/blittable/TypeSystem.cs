//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static AsciCode;
    using static TypeKind;

    using K = TypeKind;

    [ApiHost]
    public readonly partial struct TypeSystem
    {
        const byte TypeKindCount = 13;

        [MethodImpl(Inline), Op]
        public static TypeIndicator indicator(TypeKind src)
            => new TypeIndicator(skip(IndicatorSymbols,(byte)src));

        [MethodImpl(Inline), Op]
        public static TypeKind typekind(byte index)
            => skip(TypeKinds, index);

        [MethodImpl(Inline), Op]
        public static DataType type(TypeKind kind, BitWidth content, BitWidth storage)
            => new DataType(kind, content, storage);

        // define i8 @v8i16(<8 x i16> %a, <8 x i16> %b, <8 x i16> %c, <8 x i16> %d)


        [MethodImpl(Inline), Op]
        public static DataType v8(uint n)
            => type(TypeKind.Vector, n*8, n*8);

        [MethodImpl(Inline), Op]
        public static DataType v16(uint n)
            => type(TypeKind.Vector, n*16, n*16);

        [MethodImpl(Inline), Op]
        public static DataType v32(uint n)
            => type(TypeKind.Vector, n*32, n*32);

        [MethodImpl(Inline), Op]
        public static DataType v64(uint n)
            => type(TypeKind.Vector, n*64, n*64);

        [MethodImpl(Inline), Op]
        public static DataType v128(uint n)
            => type(TypeKind.Vector, n*128, n*128);

        [MethodImpl(Inline), Op]
        public static DataType v256(uint n)
            => type(TypeKind.Vector, n*256, n*256);

        [MethodImpl(Inline), Op]
        public static DataType v512(uint n)
            => type(TypeKind.Vector, n*512, n*512);

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
                case TypeKind.Char:
                break;
                case TypeKind.Enum:
                break;
                case Vector:
                break;
                case TypeKind.Array:
                break;
                case Tensor:
                break;
                case TypeKind.Domain:
                break;
                case TypeKind.Sequence:
                break;
                case TypeKind.Cube:
                break;
                case TypeKind.Name:
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

        static ReadOnlySpan<TypeKind> TypeKinds
            => new TypeKind[TypeKindCount]{
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