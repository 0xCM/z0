    //-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Part;
    using static TypeNats;

    [ApiHost]
    public readonly struct NatSpan
    {
        /// <summary>
        /// Loads a bytespan of natural length 16 from a generic source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static NatSpan<N16,byte> bytes<T>(Span<T> src, N16 n)
            where T : unmanaged
                => load(AsBytes(src),n);

        /// <summary>
        /// Loads a bytespan of natural length from a generic source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static NatSpan<N,byte> bytes<N,T>(Span<T> src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => load(AsBytes(src),n);

        /// <summary>
        /// Allocates span of natural length
        /// </summary>
        /// <param name="n">The cell count representative</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="N">The cell count type</typeparam>
        /// <typeparam name="T">The cell data type</typeparam>
        public static NatSpan<N,T> alloc<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatSpan<N,T>(sys.alloc<T>(nat64u<N>()));

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void broadcast<N,T>(T data, in NatSpan<N,T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => dst.Edit.Fill(data);

        [MethodImpl(Inline)]
        public static NatSpan<N,T> load<N,T>(T[] src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            root.require(src.Length >= (int)nat64u<N>(), () => $"The source length {src.Length} >= N := {nat64u<N>()}");
            return new NatSpan<N,T>(src);
        }

        [MethodImpl(Inline)]
        public static NatSpan<N,T> load<N,T>(Span<T> src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var len = src.Length;
            root.require(len >= nat32i<N>(), () => $"The source length {len} >= N := {nat64u<N>()}");
            return new NatSpan<N,T>(src);
        }

        /// <summary>
        /// Loads a natural block from a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="n">The length representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static NatSpan<N,T> load<N,T>(ref T src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var data = CreateSpan(ref src, (int)nat64u<N>());
            return new NatSpan<N,T>(data);
        }

        [MethodImpl(Inline)]
        public static NatSpan<N,T> parts<N,T>(N n, params T[] cells)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Span<T> src = cells;
            return load(src,n);
        }
    }
}