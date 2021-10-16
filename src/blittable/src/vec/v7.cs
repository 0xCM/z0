//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vec
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    /// <summary>
    /// Defines a 7-cell T-vector
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct v7<T> : IVector<T>
        where T : unmanaged
    {
        v6<T> A;

        v1<T> B;

        public uint N => 7;

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
            get => api.cells(ref this);
        }

        public ref T this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref seek(Cells, i);
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
    partial struct api
    {
        /// <summary>
        /// Creates a vector of specifield length and parametric type
        /// </summary>
        /// <param name="n">The length selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v7<T> v<T>(N7 n)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v7<T> v<T>(N7 n, T a0, T a1 = default, T a2 = default, T a3 = default, T a4 = default, T a5 = default, T a6 = default)
            where T : unmanaged
        {
            var v = new v7<T>();
            ref var dst = ref cell(ref v);
            seek(dst,0) = a0;
            seek(dst,1) = a1;
            seek(dst,2) = a2;
            seek(dst,3) = a3;
            seek(dst,4) = a4;
            seek(dst,5) = a5;
            seek(dst,6) = a6;
            return v;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref v7<T> src)
            where T : unmanaged
                => ref @as<v7<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(ref v7<T> src)
            where T : unmanaged
                => cover(cell(ref src), src.N);

        public static string format<T>(in v7<T> src)
            where T : unmanaged
                => string.Format(RP.V7,
                    src[0], src[1], src[2], src[3], src[4], src[5], src[7]);
   }
}