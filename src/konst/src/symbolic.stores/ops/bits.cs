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
        public static ReadOnlySpan<Symbol<UInt6,byte,N6>> bits(N6 n)
            => Bytes.cells<Symbol<UInt6,byte,N6>>(n64);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<UInt7,byte,N7>> bits(N7 n)
            => Bytes.cells<Symbol<UInt7,byte,N7>>(n128);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<Octet,byte,N8>> bits(N8 n)
            => Bytes.cells<Symbol<Octet,byte,N8>>(n256);

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='UInt1'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<UInt1,T,N1> bits<T>(N1 n)
            where T : unmanaged
                => symbols<UInt1,T,N1>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='UInt2'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<UInt2,T,N2> bits<T>(N2 n)
            where T : unmanaged
            => symbols<UInt2,T,N2>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='UInt3'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<UInt3,T,N3> bits<T>(N3 n)
            where T : unmanaged
            => symbols<UInt3,T,N3>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='UInt4'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<UInt4,T,N4> bits<T>(N4 n)
            where T : unmanaged
            => symbols<UInt4,T,N4>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='UInt5'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<UInt5,T,N5> bits<T>(N5 n)
            where T : unmanaged
            => symbols<UInt5,T,N5>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='UInt6'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<UInt6,T,N6> bits<T>(N6 n)
            where T : unmanaged
                => symbols<UInt6,T,N6>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='Octet'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<Octet,T,N8> bits<T>(N8 n)
            where T : unmanaged
                => symbols<Octet,T,N8>();
    }
}