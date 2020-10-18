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

    partial struct SymbolStore
    {
        [MethodImpl(Inline), Op]
        public static SymbolStore<Hex2Seq,byte,N2> hex(N2 n)
            => symbols<Hex2Seq,byte,N2>();

        [MethodImpl(Inline), Op]
        public static SymbolStore<Hex3Seq,byte,N3> hex(N3 n)
            => symbols<Hex3Seq,byte,N3>();

        [MethodImpl(Inline), Op]
        public static SymbolStore<Hex4Seq,byte,N4> hex(N4 n)
            => symbols<Hex4Seq,byte,N4>();

        [MethodImpl(Inline), Op]
        public static SymbolStore<Hex5Seq,byte,N5> hex(N5 n)
            => symbols<Hex5Seq,byte,N5>();

        [MethodImpl(Inline), Op]
        public static SymbolStore<Hex8Seq,byte,N8> hex(N8 n)
            => symbols<Hex8Seq,byte,N8>();

        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexSymUp> hex(byte src, UpperCased @case)
            => recover<byte,HexSymUp>(Hex.UpperDigits);

        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexSymLo> hex(byte src, LowerCased @case)
            => recover<byte,HexSymLo>(Hex.LowerDigits);
    }
}