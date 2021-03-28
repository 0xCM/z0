//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Digital
    {
        /// <summary>
        /// Returns a readonly symbol span covering each <see cref='Hex2Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<Hex2Seq,byte,N2>> hexseq(N2 n)
            => Bytes.cells<Symbol<Hex2Seq,byte,N2>>(n4);

        /// <summary>
        /// Returns a readonly symbol span covering each <see cref='Hex3Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<Hex3Seq,byte,N3>> hexseq(N3 n)
            => Bytes.cells<Symbol<Hex3Seq,byte,N3>>(n8);

        /// <summary>
        /// Returns a readonly symbol span covering each <see cref='Hex4Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<Hex4Seq,byte,N4>> hexseq(N4 n)
            => Bytes.cells<Symbol<Hex4Seq,byte,N4>>(n16);

        /// <summary>
        /// Creates a store covering each <see cref='Hex5Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<Hex5Seq,byte,N5>> hexseq(N5 n)
            => Bytes.cells<Symbol<Hex5Seq,byte,N5>>(n32);

        /// <summary>
        /// Creates a store covering each <see cref='Hex6Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static SymbolStore<Hex6Seq,byte,N6> hexseq(N6 n)
            => SymbolStores.create<Hex6Seq,byte,N6>();

        /// <summary>
        /// Creates a store covering each <see cref='Hex7Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static SymbolStore<Hex7Seq,byte,N7> hexseq(N7 n)
            => SymbolStores.create<Hex7Seq,byte,N7>();

        /// <summary>
        /// Creates a store covering each <see cref='Hex8Seq'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        [MethodImpl(Inline), Op]
        public static SymbolStore<Hex8Seq,byte,N8> hex(N8 n)
            => SymbolStores.create<Hex8Seq,byte,N8>();
    }
}