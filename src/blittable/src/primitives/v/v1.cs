//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct BitFlow
    {
        /// <summary>
        /// Creates a vector of specifield length and parametric type
        /// </summary>
        /// <param name="n">The length selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v1<T> v<T>(N1 n)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v1<T> v<T>(N1 n, T a0)
            where T : unmanaged
                => a0;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref v1<T> src)
            where T : unmanaged
                => ref @as<v1<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(ref v1<T> src)
            where T : unmanaged
                => cover(cell(ref src), src.N);

        /// <summary>
        /// Defines a 1-cell T-vector
        /// </summary>
        public struct v1<T> : IVector<T>
            where T : unmanaged
        {
            public static ByteSize SZ => size<v1<T>>();

            T C0;

            [MethodImpl(Inline)]
            public v1(T src)
            {
                C0 = src;
            }

            public uint N => 1;

            public Span<T> Cells
            {
                [MethodImpl(Inline)]
                get => cells(ref this);
            }

            public ref T this[uint i]
            {
                [MethodImpl(Inline)]
                get => ref seek(Cells, i);
            }

            public BitWidth StorageWidth
            {
                [MethodImpl(Inline)]
                get => N*size<T>();
            }

            public BitWidth ContentWidth
            {
                [MethodImpl(Inline)]
                get => StorageWidth;
            }

            public string Format()
                => format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator v1<T>(T src)
                => new v1<T>(src);
        }
   }
}