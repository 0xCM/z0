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
        public static v12<T> v<T>(N12 n)
            where T : unmanaged
                => default;

        [Op, Closures(Closure)]
        public static string format<T>(in v12<T> src)
            where T : unmanaged
                => string.Format(RP.V8,
                    src[0], src[1], src[2], src[3], src[4], src[5], src[6], src[7],
                    src[8], src[9]);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref v12<T> src)
            where T : unmanaged
                => ref @as<v12<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(ref v12<T> src)
            where T : unmanaged
                => cover(cell(ref src), src.N);

        /// <summary>
        /// Defines a 12-cell T-vector
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct v12<T> : IVector<T>
            where T : unmanaged
        {
            public static ByteSize SZ => size<v12<T>>();

            v10<T> A;

            v2<T> B;

            public uint N => 12;

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