//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        /// <summary>
        /// Creates a vector of specifield length and parametric type
        /// </summary>
        /// <param name="n">The length selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v2<T> v<T>(N2 n)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v2<T> v<T>(N2 n, T a0, T a1 = default)
            where T : unmanaged
        {
            var v = new v2<T>();
            ref var dst = ref cell(ref v);
            seek(dst,0) = a0;
            seek(dst,1) = a1;
            return v;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref v2<T> src)
            where T : unmanaged
                => ref @as<v2<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(ref v2<T> src)
            where T : unmanaged
                => cover(cell(ref src), src.N);

        public static string format<T>(in v2<T> src)
            where T : unmanaged
                => string.Format(RP.V2, src[0], src[1]);

        /// <summary>
        /// Defines a 2-cell T-vector
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct v2<T> : IVector<T>
            where T : unmanaged
        {
            public static ByteSize SZ => size<v2<T>>();
            v1<T> C0;

            v1<T> C1;

            public uint N => 2;

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

            public string Format()
                => format(this);

            public override string ToString()
                => Format();
        }
   }
}