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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v16<T> v<T>(N16 n)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v16<T> v<T>(N16 n, v8<T> a0, v8<T> a1 = default)
            where T : unmanaged
        {
            var v = new v16<T>();
            ref var dst = ref @as<T,v8<T>>(cell(ref v));
            seek(dst,0) = a0;
            seek(dst,1) = a1;
            return v;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref v16<T> src)
            where T : unmanaged
                => ref @as<v16<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(ref v16<T> src)
            where T : unmanaged
                => cover(cell(ref src), src.N);

        [Op, Closures(Closure)]
        public static string format<T>(in v16<T> src)
            where T : unmanaged
                => string.Format(RP.V16,
                    src[0],  src[1],  src[2],  src[3],  src[4],  src[5],  src[6],  src[7],
                    src[8],  src[9],  src[10], src[11], src[12], src[13], src[14], src[15]
                    );

        /// <summary>
        /// Defines a 16-cell T-vector
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct v16<T> : IVector<T>
            where T : unmanaged
        {
            public static ByteSize SZ => size<v16<T>>();

            v8<T> A;

            v8<T> B;

            public uint N => 16;

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