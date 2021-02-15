//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct SymbolStores
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq1,byte,N1>> bitseq(N1 n)
            => Bytes.cells<Symbol<BitSeq1,byte,N1>>(n2);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq2,byte,N2>> bitseq(N2 n)
            => Bytes.cells<Symbol<BitSeq2,byte,N2>>(n4);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq3,byte,N3>> bitseq(N3 n)
            => Bytes.cells<Symbol<BitSeq3,byte,N3>>(n8);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq4,byte,N4>> bitseq(N4 n)
            => Bytes.cells<Symbol<BitSeq4,byte,N4>>(n16);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq5,byte,N5>> bitseq(N5 n)
            => Bytes.cells<Symbol<BitSeq5,byte,N5>>(n32);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq6,byte,N6>> bitseq(N6 n)
            => Bytes.cells<Symbol<BitSeq6,byte,N6>>(n64);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq7,byte,N7>> bitseq(N7 n)
            => Bytes.cells<Symbol<BitSeq7,byte,N7>>(n128);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq8,byte,N8>> bitseq(N8 n)
            => Bytes.cells<Symbol<BitSeq8,byte,N8>>(n256);

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq1'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq1,T,N1> bitseq<T>(N1 n)
            where T : unmanaged
                => create<BitSeq1,T,N1>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq2'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq2,T,N2> bitseq<T>(N2 n)
            where T : unmanaged
                => create<BitSeq2,T,N2>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq3'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq3,T,N3> bitseq<T>(N3 n)
            where T : unmanaged
            => create<BitSeq3,T,N3>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq4'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq4,T,N4> bitseq<T>(N4 n)
            where T : unmanaged
            => create<BitSeq4,T,N4>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq5'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq5,T,N5> bitseq<T>(N5 n)
            where T : unmanaged
                => create<BitSeq5,T,N5>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq6'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq6,T,N6> bitseq<T>(N6 n)
            where T : unmanaged
                => create<BitSeq6,T,N6>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq8'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq8,T,N8> bitseq<T>(N8 n)
            where T : unmanaged
                => create<BitSeq8,T,N8>();
    }
}