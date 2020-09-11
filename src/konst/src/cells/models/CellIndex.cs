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

    public readonly struct CellIndex
    {
        public static CellIndex<F> Alloc<F>(int length)
            where F : unmanaged, IDataCell
                => new CellIndex<F>(new F[length]);

        [MethodImpl(Inline)]
        public static CellIndex<F> From<F>(Span<F> src)
            where F : unmanaged, IDataCell
                => new CellIndex<F>(src);

        [MethodImpl(Inline)]
        public static CellIndex<F,T> From<F,T>(Span<F> src)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => new CellIndex<F,T>(src);
    }

    public readonly ref struct CellIndex<F>
        where F : struct, IDataCell
    {
        public static uint ItemWidth
            => bitsize<F>();

        readonly Span<F> data;

        [MethodImpl(Inline)]
        public CellIndex(Span<F> src)
        {
            this.data = src;
        }

        public ref F this[int index]
        {
            [MethodImpl(Inline)]
            get => ref seek(data, (uint)index);
        }

        [MethodImpl(Inline)]
        public ref F Seek(int index)
            => ref this[index];

        public int Length
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public int ItemCount
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        [MethodImpl(Inline)]
        public Span<F> ToSpan()
            => data;

        [MethodImpl(Inline)]
        public ReadOnlySpan<F> ToReadOnlySpan()
            => data;

        public F[] ToArray()
            => data.ToArray();
    }

    public readonly ref struct CellIndex<F,T>
        where F : struct, IDataCell
        where T : struct
     {
        public static uint ItemWidth => bitsize<F>();

        public static uint CellWidth => bitsize<T>();

        readonly Span<F> data;

        [MethodImpl(Inline)]
        public CellIndex(Span<F> src)
        {
            this.data = src;
        }

        public ref F this[int item]
        {
            [MethodImpl(Inline)]
            get => ref seek(data, (uint)item);
        }

        public ref T this[int item, int cell]
        {
            [MethodImpl(Inline)]
            get => ref @as<F,T>(seek(seek(data, (uint)item), cell));
        }

        [MethodImpl(Inline)]
        public ref F Seek(int item)
            => ref this[item];

        [MethodImpl(Inline)]
        public ref T Seek(int item, int cell)
            => ref this[item,cell];

        [MethodImpl(Inline)]
        public Span<F> ToSpan()
            => data;

        [MethodImpl(Inline)]
        public ReadOnlySpan<F> ToReadOnlySpan()
            => data;

        public F[] ToArray()
            => data.ToArray();

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => data.Cast<F,T>();
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public int ItemCount
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public int CellCount
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }
    }
}