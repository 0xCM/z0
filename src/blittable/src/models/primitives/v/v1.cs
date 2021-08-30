//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        /// <summary>
        /// Defines a 1-cell T-vector
        /// </summary>
        public struct v1<T> : IVector<T>
            where T : unmanaged
        {
            T C0;

            [MethodImpl(Inline)]
            public v1(T src)
            {
                C0 = src;
            }

            public uint N => 1;

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

            public string Format()
                => Operate.vformat(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator v1<T>(T src)
                => new v1<T>(src);
        }
   }
}