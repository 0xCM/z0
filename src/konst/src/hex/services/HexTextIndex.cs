//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static core;
    using static Typed;


    using H = Hex3;
    using K = Hex3Kind;
    using T = Hex3Text;
    using N = N3;

    [ApiHost]
    public readonly struct HexTextIndex
    {
        [MethodImpl(Inline), Op]
        public static HexTextIndex<K> strings(N n, StringRef[] dst)
        {
            var target = span(dst);
            byte i = 0;
            seek(target,i++) = StringRefs.create(T.x00);
            seek(target,i++) = StringRefs.create(T.x01);
            seek(target,i++) = StringRefs.create(T.x02);            
            seek(target,i++) = StringRefs.create(T.x03);
            seek(target,i++) = StringRefs.create(T.x04);
            seek(target,i++) = StringRefs.create(T.x05);
            seek(target,i++) = StringRefs.create(T.x06);            
            seek(target,i++) = StringRefs.create(T.x07);
            return new HexTextIndex<K>(dst);
        }                
        
        [MethodImpl(Inline)]
        public static HexIndex<K> index<K>(K[] src)
            where K : unmanaged, IHexNumber
                => new HexIndex<K>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<H> index(H[] src)
            => index<H>(src);

        [MethodImpl(Inline)]
        public static HexTextIndex<K> init<K>()
            where K : unmanaged, Enum
        {
            if(typeof(K) == typeof(Hex1Kind))
                return Hex.generic<K>(init(n1));
            else if(typeof(K) == typeof(Hex2Kind))
                return Hex.generic<K>(init(n2));
            else if(typeof(K) == typeof(Hex3Kind))
                return Hex.generic<K>(init(n3));
            else if(typeof(K) == typeof(Hex4Kind))
                return Hex.generic<K>(init(n4));
            else
                return HexTextIndex<K>.Empty;
        }        

        [MethodImpl(Inline), Op]
        public static HexTextIndex<Hex1Kind> init(N1 n)
            => new HexTextIndex<Hex1Kind>(sys.array(@ref(Hex1Text.x00), @ref(Hex1Text.x01)));

        [MethodImpl(Inline), Op]
        public static HexTextIndex<Hex2Kind> init(N2 n)
            => new HexTextIndex<Hex2Kind>(sys.array(
                @ref(Hex2Text.x00), @ref(Hex2Text.x01), 
                @ref(Hex2Text.x02), @ref(Hex2Text.x03)
                ));

        [Op]
        public static HexTextIndex<Hex3Kind> init(N3 n)
            => new HexTextIndex<Hex3Kind>(sys.array(
                    @ref(Hex3Text.x00), @ref(Hex3Text.x01), @ref(Hex3Text.x02), @ref(Hex3Text.x03),
                    @ref(Hex3Text.x04), @ref(Hex3Text.x05), @ref(Hex3Text.x06), @ref(Hex3Text.x07)
                        ));

        [Op]
        public static HexTextIndex<Hex4Kind> init(N4 n)
            => new HexTextIndex<Hex4Kind>(sys.array(
                    @ref(Hex4Text.x00), @ref(Hex4Text.x01), @ref(Hex4Text.x02), @ref(Hex4Text.x03),
                    @ref(Hex4Text.x04), @ref(Hex4Text.x05), @ref(Hex4Text.x06), @ref(Hex4Text.x07),
                    @ref(Hex4Text.x08), @ref(Hex4Text.x09), @ref(Hex4Text.x0A), @ref(Hex4Text.x0B),
                    @ref(Hex4Text.x0C), @ref(Hex4Text.x0D), @ref(Hex4Text.x0E), @ref(Hex4Text.x0F)
                    ));        
        
        [MethodImpl(Inline), Op]
        public static HexIndex<Hex5> init(Hex5Kind[] src)
            => index<Hex5>(@as<Hex5Kind[],Hex5[]>(src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex6> init(Hex6Kind[] src)
            => index<Hex6>(@as<Hex6Kind[],Hex6[]>(src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex8> init(Hex8Kind[] src)
            => index<Hex8>(@as<Hex8Kind[],Hex8[]>(src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex1> init(N1 n, byte[] src)
            => index<Hex1>(@as<byte[],Hex1[]>(src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex2> init(N2 n, byte[] src)
            => index<Hex2>(@as<byte[],Hex2[]>(src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex4> init(N4 n, byte[] src)
            => index<Hex4>(@as<byte[],Hex4[]>(src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex5> init(N5 n, byte[] src)
            => index<Hex5>(@as<byte[],Hex5[]>(src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex6> init(N6 n, byte[] src)
            => index<Hex6>(@as<byte[],Hex6[]>(src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex8> init(N8 n, byte[] src)
            => index<Hex8>(@as<byte[],Hex8[]>(src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex1> init(Hex1[] src)
            => index<Hex1>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex2> init(Hex2[] src)
            => index<Hex2>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex4> init(Hex4[] src)
            => index<Hex4>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex5> init(Hex5[] src)
            => index<Hex5>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex6> init(Hex6[] src)
            => index<Hex6>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex8> init(Hex8[] src)
            => index<Hex8>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<H> init(N n, byte[] src)
            => index<H>(@as<byte[],H[]>(src));


    }    
}