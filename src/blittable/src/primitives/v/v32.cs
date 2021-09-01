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
                get => Operate.cells(ref this);
            }

            public ref T this[uint i]
            {
                [MethodImpl(Inline)]
                get => ref seek(Cells, i);
            }

            public string Format()
                => Render.format(this);

            public override string ToString()
                => Format();
        }
   }
}