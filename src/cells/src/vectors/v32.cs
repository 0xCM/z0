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
    /// Defines a 32-cell T-vector
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct v32<T> : IVector<T>
        where T : unmanaged
    {
        v16<T> A;

        v16<T> B;

        public uint N => 32;

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
        public static v32<T> v<T>(N32 n)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v32<T> v<T>(N32 n, v16<T> a0, v16<T> a1 = default)
            where T : unmanaged
        {
            var v = new v32<T>();
            ref var dst = ref @as<T,v16<T>>(cell(ref v));
            seek(dst,0) = a0;
            seek(dst,1) = a1;
            return v;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref v32<T> src)
            where T : unmanaged
                => ref @as<v32<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(ref v32<T> src)
            where T : unmanaged
                => cover(cell(ref src), src.N);

        public static string format<T>(in v32<T> src)
            where T : unmanaged
                => string.Format(RP.V32,
                    src[0],  src[1],  src[2],  src[3],  src[4],  src[5],  src[6],  src[7],  src[8], src[9],
                    src[10], src[11], src[12], src[13], src[14], src[15], src[16], src[17], src[18], src[19],
                    src[20], src[21], src[22], src[23], src[24], src[25], src[26], src[27], src[28], src[29],
                    src[30], src[31]
                    );
        }
}