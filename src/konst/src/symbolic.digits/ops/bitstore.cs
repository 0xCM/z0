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
        /// Creates a cell-parametric store store covering each <see cref='BitSeq1'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq1,T,N1> bitstore<T>(N1 n)
            where T : unmanaged
                => SymbolStores.create<BitSeq1,T,N1>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq2'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq2,T,N2> bitstore<T>(N2 n)
            where T : unmanaged
                => SymbolStores.create<BitSeq2,T,N2>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq3'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq3,T,N3> bitstore<T>(N3 n)
            where T : unmanaged
            => SymbolStores.create<BitSeq3,T,N3>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq4'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq4,T,N4> bitstore<T>(N4 n)
            where T : unmanaged
                => SymbolStores.create<BitSeq4,T,N4>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq5'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq5,T,N5> bitstore<T>(N5 n)
            where T : unmanaged
                => SymbolStores.create<BitSeq5,T,N5>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq6'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq6,T,N6> bitstore<T>(N6 n)
            where T : unmanaged
                => SymbolStores.create<BitSeq6,T,N6>();

        /// <summary>
        /// Creates a cell-parametric store store covering each <see cref='BitSeq8'/> member
        /// </summary>
        /// <param name="n">The sequence length selector</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq8,T,N8> bitstore<T>(N8 n)
            where T : unmanaged
                => SymbolStores.create<BitSeq8,T,N8>();
    }
}