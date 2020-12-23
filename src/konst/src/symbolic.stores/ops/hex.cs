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
        /// <summary>
        /// Returns a readonly symbol span covering each <see cref='Hex2Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<Hex2Seq,byte,N2>> hex(N2 n)
            => Bytes.cells<Symbol<Hex2Seq,byte,N2>>(n4);

        /// <summary>
        /// Returns a readonly symbol span covering each <see cref='Hex3Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<Hex3Seq,byte,N3>> hex(N3 n)
            => Bytes.cells<Symbol<Hex3Seq,byte,N3>>(n8);

        /// <summary>
        /// Returns a readonly symbol span covering each <see cref='Hex4Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<Hex4Seq,byte,N4>> hex(N4 n)
            => Bytes.cells<Symbol<Hex4Seq,byte,N4>>(n16);

        /// <summary>
        /// Creates a store covering each <see cref='Hex5Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<Hex5Seq,byte,N5>> hex(N5 n)
            => Bytes.cells<Symbol<Hex5Seq,byte,N5>>(n32);

        /// <summary>
        /// Creates a store covering each <see cref='Hex6Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static SymbolStore<Hex6Seq,byte,N6> hex(N6 n)
            => symbols<Hex6Seq,byte,N6>();

        /// <summary>
        /// Creates a store covering each <see cref='Hex7Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static SymbolStore<Hex7Seq,byte,N7> hex(N7 n)
            => symbols<Hex7Seq,byte,N7>();

        /// <summary>
        /// Creates a store covering each <see cref='Hex8Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
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
            => recover<byte,HexSymUp>(HexCharData.UpperHexDigits);

        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexSymLo> hex(byte src, LowerCased @case)
            => recover<byte,HexSymLo>(HexCharData.LowerHexDigits);
    }
}