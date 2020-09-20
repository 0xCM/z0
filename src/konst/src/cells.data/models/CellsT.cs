//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct Cells<T>
        where T : struct, IDataCell
    {
        public static uint CellWidth
            => bitwidth<T>();

        readonly T[] Data;

        [MethodImpl(Inline)]
        public Cells(T[] src)
            => Data = src;

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get =>  Data;
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get =>  Data;
        }

        public ref T this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public ref T Seek(long index)
            => ref this[index];

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
    }
}