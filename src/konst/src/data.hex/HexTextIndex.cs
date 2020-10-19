//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using H = Hex3;
    using K = Hex3Seq;
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
            seek(target,i++) = @ref(T.x00);
            seek(target,i++) = @ref(T.x01);
            seek(target,i++) = @ref(T.x02);
            seek(target,i++) = @ref(T.x03);
            seek(target,i++) = @ref(T.x04);
            seek(target,i++) = @ref(T.x05);
            seek(target,i++) = @ref(T.x06);
            seek(target,i++) = @ref(T.x07);
            return new HexTextIndex<K>(dst);
        }

        [MethodImpl(Inline)]
        public static HexIndex<K> index<K>(K[] src)
            where K : unmanaged, IHexNumber
                => new HexIndex<K>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<H> init(N n, byte[] src)
            => index<H>(@as<byte[],H[]>(src));

        [MethodImpl(Inline)]
        public static HexTextIndex<K> init<K>()
            where K : unmanaged, Enum
        {
            if(typeof(K) == typeof(Hex1Seq))
                return Hex.generic<K>(init(n1));
            else if(typeof(K) == typeof(Hex2Seq))
                return Hex.generic<K>(init(n2));
            else if(typeof(K) == typeof(Hex3Seq))
                return Hex.generic<K>(init(n3));
            else if(typeof(K) == typeof(Hex4Seq))
                return Hex.generic<K>(init(n4));
            else
                return HexTextIndex<K>.Empty;
        }

        [MethodImpl(Inline), Op]
        public static HexTextIndex<Hex1Seq> init(N1 n)
            => new HexTextIndex<Hex1Seq>(sys.array(@ref(Hex1Text.x00), @ref(Hex1Text.x01)));

        [MethodImpl(Inline), Op]
        public static HexTextIndex<Hex2Seq> init(N2 n)
            => new HexTextIndex<Hex2Seq>(sys.array(
                @ref(Hex2Text.x00), @ref(Hex2Text.x01),
                @ref(Hex2Text.x02), @ref(Hex2Text.x03)
                ));

        [Op]
        public static HexTextIndex<Hex3Seq> init(N3 n)
            => new HexTextIndex<Hex3Seq>(sys.array(
                    @ref(Hex3Text.x00), @ref(Hex3Text.x01), @ref(Hex3Text.x02), @ref(Hex3Text.x03),
                    @ref(Hex3Text.x04), @ref(Hex3Text.x05), @ref(Hex3Text.x06), @ref(Hex3Text.x07)
                        ));

        [Op]
        public static HexTextIndex<Hex4Seq> init(N4 n)
            => new HexTextIndex<Hex4Seq>(sys.array(
                    @ref(Hex4Text.x00), @ref(Hex4Text.x01), @ref(Hex4Text.x02), @ref(Hex4Text.x03),
                    @ref(Hex4Text.x04), @ref(Hex4Text.x05), @ref(Hex4Text.x06), @ref(Hex4Text.x07),
                    @ref(Hex4Text.x08), @ref(Hex4Text.x09), @ref(Hex4Text.x0A), @ref(Hex4Text.x0B),
                    @ref(Hex4Text.x0C), @ref(Hex4Text.x0D), @ref(Hex4Text.x0E), @ref(Hex4Text.x0F)
                    ));
    }
}