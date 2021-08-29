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
    using static Blit.Operate;

    partial struct Blit
    {
        /// <summary>
        /// Defines a 2-cell T-vector
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct v2<T> : IVector<T>
            where T : unmanaged
        {
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
                get => Operate.vcells(ref this);
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