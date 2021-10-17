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
    /// Defines a 9-cell T-vector
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct v9<T> : IVector<T>
        where T : unmanaged
    {
        v8<T> A;

        v1<T> B;

        public uint N => 9;

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
        public static v9<T> v<T>(N9 n)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v9<T> v<T>(N9 n, T a0, T a1 = default, T a2 = default, T a3 = default, T a4 = default, T a5 = default, T a6 = default, T a7 = default, T a8 = default)
            where T : unmanaged
        {
            var v = new v9<T>();
            ref var dst = ref cell(ref v);
            seek(dst,0) = a0;
            seek(dst,1) = a1;
            seek(dst,2) = a2;
            seek(dst,3) = a3;
            seek(dst,4) = a4;
            seek(dst,5) = a5;
            seek(dst,6) = a6;
            seek(dst,7) = a7;
            seek(dst,8) = a8;
            return v;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref v9<T> src)
            where T : unmanaged
                => ref @as<v9<T>,T>(src);


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(ref v9<T> src)
            where T : unmanaged
                => cover(cell(ref src), src.N);

        public static string format<T>(in v9<T> src)
            where T : unmanaged
                => string.Format(RP.V9,
                    src[0], src[1], src[2], src[3], src[4], src[5], src[6], src[7], src[8]);

   }
}