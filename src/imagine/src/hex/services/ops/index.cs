//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    partial class Hex
    {
        [MethodImpl(Inline), Op]
        public static HexIndex<Hex5> index(Hex5Kind[] src)
            => index<Hex5>(As.@as<Hex5Kind[],Hex5[]>(ref src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex6> index(Hex6Kind[] src)
            => index<Hex6>(As.@as<Hex6Kind[],Hex6[]>(ref src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex8> index(Hex8Kind[] src)
            => index<Hex8>(As.@as<Hex8Kind[],Hex8[]>(ref src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex1> index(N1 n, byte[] src)
            => index<Hex1>(As.@as<byte[],Hex1[]>(ref src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex2> index(N2 n, byte[] src)
            => index<Hex2>(As.@as<byte[],Hex2[]>(ref src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex3> index(N3 n, byte[] src)
            => index<Hex3>(As.@as<byte[],Hex3[]>(ref src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex4> index(N4 n, byte[] src)
            => index<Hex4>(As.@as<byte[],Hex4[]>(ref src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex5> index(N5 n, byte[] src)
            => index<Hex5>(As.@as<byte[],Hex5[]>(ref src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex6> index(N6 n, byte[] src)
            => index<Hex6>(As.@as<byte[],Hex6[]>(ref src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex8> index(N8 n, byte[] src)
            => index<Hex8>(As.@as<byte[],Hex8[]>(ref src));

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex1> index(Hex1[] src)
            => index<Hex1>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex2> index(Hex2[] src)
            => index<Hex2>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex3> index(Hex3[] src)
            => index<Hex3>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex4> index(Hex4[] src)
            => index<Hex4>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex5> index(Hex5[] src)
            => index<Hex5>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex6> index(Hex6[] src)
            => index<Hex6>(src);

        [MethodImpl(Inline), Op]
        public static HexIndex<Hex8> index(Hex8[] src)
            => index<Hex8>(src);

        [MethodImpl(Inline)]
        public static HexIndex<K> index<K>(K[] src)
            where K : unmanaged, IHexNumber
                => new HexIndex<K>(src);

        [MethodImpl(Inline), Op]
        public static HexTextIndex<Hex3Kind> index(N3 n, StringRef[] buffer)
        {
            var dst = Root.span(buffer);
            byte i = 0;
            seek(dst,i++) = @ref(Hex3Text.x00);
            seek(dst,i++) = @ref(Hex3Text.x01);
            seek(dst,i++) = @ref(Hex3Text.x02);            
            seek(dst,i++) = @ref(Hex3Text.x03);
            seek(dst,i++) = @ref(Hex3Text.x04);
            seek(dst,i++) = @ref(Hex3Text.x05);
            seek(dst,i++) = @ref(Hex3Text.x06);            
            seek(dst,i++) = @ref(Hex3Text.x07);
            return new HexTextIndex<Hex3Kind>(buffer);
        }
     }
}