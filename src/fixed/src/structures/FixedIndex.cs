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
    using static Memories;
    
    public static class FixedIndexes
    {
        public static FixedIndex<F> Alloc<F>(int length)
            where F : unmanaged, IFixed
                => new FixedIndex<F>(new F[length]);

        [MethodImpl(Inline)]
        public static FixedIndex<F> From<F>(Span<F> src)
            where F : unmanaged, IFixed
                => new FixedIndex<F>(src);

        [MethodImpl(Inline)]
        public static FixedIndex<F,T> From<F,T>(Span<F> src)
            where F : unmanaged, IFixed
            where T : unmanaged
                => new FixedIndex<F,T>(src);
    }

    public readonly ref struct FixedIndex<F>
        where F : unmanaged, IFixed     
    {
        public static int ItemWidth => bitsize<F>();

        readonly Span<F> data;

        [MethodImpl(Inline)]
        internal FixedIndex(Span<F> src)
        {
            this.data = src;
        }

        public ref F this[int index]
        {
            [MethodImpl(Inline)]
            get => ref seek(data, index);
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

    public readonly ref struct FixedIndex<F,T>
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        public static int ItemWidth => bitsize<F>();
        
        public static int CellWidth => bitsize<T>();        
        
        readonly Span<F> data;

        [MethodImpl(Inline)]
        internal FixedIndex(Span<F> src)
        {
            this.data = src;
        }

        public ref F this[int item]
        {
            [MethodImpl(Inline)]
            get => ref seek(data, item);
        }

        public ref T this[int item, int cell]
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.As<F,T>(ref seek(ref seek(data, item), cell));
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
            get => data.As<F,T>();
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