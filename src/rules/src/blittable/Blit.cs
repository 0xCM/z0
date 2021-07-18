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
    using static Rules;

    using C = AsciCode;
    using K = TypeKind;

    [ApiHost]
    public readonly partial struct TypeSystem
    {
        const byte TypeKindCount = 11;

        [MethodImpl(Inline), Op]
        public static TypeIndicator indicator(TypeKind src)
            => new TypeIndicator(skip(IndicatorSymbols,(byte)src));

        [MethodImpl(Inline), Op]
        public static TypeKind typekind(byte index)
            => skip(TypeKinds,index);

        // [MethodImpl(Inline), Op]
        // public static TypeKind typekind(TypeIndicator src)
        // {

        // }

        // static Bijection<AsciCode,TypeKind> biject()
        // {

        // }

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
                (byte)s,10
                };


        static ReadOnlySpan<AsciCode> IndicatorSymbols
            => new AsciCode[TypeKindCount]{Question,u,i,f,c,e,v,a,t,d,s};

        static ReadOnlySpan<TypeKind> TypeKinds
            => new TypeKind[TypeKindCount]{K.Unknown,K.Unsigned,K.Signed,K.Float,K.Char,K.Enum,K.Vector,K.Array,K.Tensor,K.Domain,K.Sequence};

    }
}