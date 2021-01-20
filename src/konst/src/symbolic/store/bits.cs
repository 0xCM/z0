//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct SymbolStore
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq6,byte,N6>> bits(N6 n)
            => Bytes.cells<Symbol<BitSeq6,byte,N6>>(n64);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq7,byte,N7>> bits(N7 n)
            => Bytes.cells<Symbol<BitSeq7,byte,N7>>(n128);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq8,byte,N8>> bits(N8 n)
            => Bytes.cells<Symbol<BitSeq8,byte,N8>>(n256);

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq1'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq1,T,N1> bits<T>(N1 n)
            where T : unmanaged
                => symbols<BitSeq1,T,N1>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq2'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq2,T,N2> bits<T>(N2 n)
            where T : unmanaged
            => symbols<BitSeq2,T,N2>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq3'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq3,T,N3> bits<T>(N3 n)
            where T : unmanaged
            => symbols<BitSeq3,T,N3>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq4'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq4,T,N4> bits<T>(N4 n)
            where T : unmanaged
            => symbols<BitSeq4,T,N4>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq5'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq5,T,N5> bits<T>(N5 n)
            where T : unmanaged
            => symbols<BitSeq5,T,N5>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq6'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq6,T,N6> bits<T>(N6 n)
            where T : unmanaged
                => symbols<BitSeq6,T,N6>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq8'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq8,T,N8> bits<T>(N8 n)
            where T : unmanaged
                => symbols<BitSeq8,T,N8>();
    }
}