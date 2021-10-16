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
    /// Defines a 4-cell T-vector
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct v4<T> : IVector<T>
        where T : unmanaged
    {
        public static ByteSize SZ => size<v4<T>>();

        v2<T> A;

        v2<T> B;

        public uint N => 4;

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
        public static v4<T> v<T>(N4 n)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v4<T> v<T>(N4 n, T a0, T a1 = default, T a2 = default, T a3 = default)
            where T : unmanaged
        {
            var v = new v4<T>();
            ref var dst = ref cell(ref v);
            seek(dst,0) = a0;
            seek(dst,1) = a1;
            seek(dst,2) = a2;
            seek(dst,3) = a3;
            return v;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v4<T> v<T>(N4 n, v2<T> a0, v2<T> a1)
            where T : unmanaged
        {
            var v = new v4<T>();
            lo(ref v) = a0;
            hi(ref v) = a1;
            return v;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref v4<T> src)
            where T : unmanaged
                => ref @as<v4<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref v2<T> lo<T>(ref v4<T> src)
            where T : unmanaged
                => ref @as<v4<T>,v2<T>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref v2<T> hi<T>(ref v4<T> src)
            where T : unmanaged
                => ref seek(@as<v4<T>,v2<T>>(src),1);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(ref v4<T> src)
            where T : unmanaged
                => cover(cell(ref src), src.N);

        public static string format<T>(in v4<T> src)
            where T : unmanaged
                => string.Format(RP.V4,
                    src[0], src[1], src[2], src[3]);

   }
}