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
    /// Defines a 64-cell T-vector
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct v64<T> : IVector<T>
        where T : unmanaged
    {
        v32<T> A;

        v32<T> B;

        public uint N => 64;

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
        public static v64<T> v<T>(N64 n)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v64<T> v<T>(N64 n, v32<T> a0, v32<T> a1 = default)
            where T : unmanaged
        {
            var v = new v64<T>();
            ref var dst = ref @as<T,v32<T>>(cell(ref v));
            seek(dst,0) = a0;
            seek(dst,1) = a1;
            return v;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref v64<T> src)
            where T : unmanaged
                => ref @as<v64<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(ref v64<T> src)
            where T : unmanaged
                => cover(cell(ref src), src.N);

        public static string format<T>(in v1<T> src)
            where T : unmanaged
                => string.Format(RP.V1, src[0]);

        public static string format<T>(in v64<T> src)
            where T : unmanaged
                => string.Format(RP.V64,
                    src[0],  src[1],  src[2],  src[3],  src[4],  src[5],  src[6],  src[7],  src[8], src[9],
                    src[10], src[11], src[12], src[13], src[14], src[15], src[16], src[17], src[18], src[19],
                    src[20], src[21], src[22], src[23], src[24], src[25], src[26], src[27], src[28], src[29],
                    src[30], src[31], src[32], src[33], src[34], src[35], src[36], src[37], src[38], src[39],
                    src[40], src[41], src[42], src[43], src[44], src[45], src[46], src[47], src[48], src[49],
                    src[50], src[51], src[52], src[53], src[54], src[55], src[56], src[57], src[58], src[59],
                    src[60], src[61], src[62], src[63]
                    );
    }
}