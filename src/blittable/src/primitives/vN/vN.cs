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

    partial struct BitFlow
    {
        [MethodImpl(Inline)]
        public static vector<N,T> v<N,T>(N n, T[] src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(Typed.nat32i<N>() != src.Length)
                return BitFlow.vector<N,T>.Empty;
            else
                return new vector<N,T>(src);
        }

        public static string format<N,T>(in vector<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var cells = src.Cells;
            var count = cells.Length;
            var buffer = text.buffer();
            var last = cells.Length - 1;
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref skip(cells,i);
                var fmt = string.Format("{0}", cell).Trim();
                if(nonempty(fmt))
                {
                    buffer.Append(fmt);
                    if(i != last)
                        buffer.Append(Chars.Comma);

                }
                else
                    break;
            }
            return buffer.Emit();
        }

        public struct vector<N,T> : IVector<T>
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            public static ByteSize SZ => size<T>()*Typed.nat32u<N>();

            readonly Index<T> Data;

            [MethodImpl(Inline)]
            internal vector(T[] src)
            {
                Data = src;
            }

            public Span<T> Cells
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
            }

            [MethodImpl(Inline)]
            public ref T Cell(uint index)
                => ref Data[index];

            public ref T this[uint index]
            {
                [MethodImpl(Inline)]
                get => ref Cell(index);
            }

            public string Format()
                => format(this);

            public override string ToString()
                => Format();

            BitWidth IPrimitive.StorageWidth
                => Data.Length*width<T>();

            BitWidth IPrimitive.ContentWidth
                => Data.Length* Typed.nat32u<N>();

            uint IVector.N
                => Typed.nat32u<N>();

            public static vector<N,T> Empty => default;
        }
    }
}