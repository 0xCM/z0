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
        public static v5<T> v<T>(N5 n)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v5<T> v<T>(N5 n, T a0, T a1 = default, T a2 = default, T a3 = default, T a4 = default)
            where T : unmanaged
        {
            var v = new v5<T>();
            ref var dst = ref cell(ref v);
            seek(dst,0) = a0;
            seek(dst,1) = a1;
            seek(dst,2) = a2;
            seek(dst,3) = a3;
            seek(dst,4) = a4;
            return v;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref v5<T> src)
            where T : unmanaged
                => ref @as<v5<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(ref v5<T> src)
            where T : unmanaged
                => cover(cell(ref src), src.N);

        [Op, Closures(Closure)]
        public static string format<T>(in v8<T> src)
            where T : unmanaged
                => string.Format(RP.V8,
                    src[0], src[1], src[2], src[3], src[4], src[5], src[6], src[7]);

        /// <summary>
        /// Defines a 5-cell T-vector
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct v5<T> : IVector<T>
            where T : unmanaged
        {
            public static ByteSize SZ => size<v5<T>>();

            v4<T> A;

            v1<T> B;

            public uint N => 5;

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