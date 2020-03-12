//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class FixedIndex
    {
        public static FixedIndex<F> Alloc<F>(int length)
            where F : unmanaged, IFixed
                => new FixedIndex<F>(new F[length]);

        public static FixedTripleIndex<F> AllocTriple<F>(int length)
            where F : unmanaged, IFixed
                => new FixedTripleIndex<F>(new F[length], new F[length], new F[length]);

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
        public ref F Element(int index)
            => ref this[index];
        
        public int Length
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

    public readonly ref struct FixedTripleIndex<F>
        where F : unmanaged, IFixed     
    {
        readonly Span<F> a;

        readonly Span<F> b;

        readonly Span<F> c;

        [MethodImpl(Inline)]
        internal FixedTripleIndex(Span<F> a, Span<F> b, Span<F> c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public (F a, F b, F c) this[int index]
        {
            [MethodImpl(Inline)]
            get => Element(index);

            [MethodImpl(Inline)]
            set => Element(index,value);            
        }

        [MethodImpl(Inline)]
        public  (F a, F b, F c) Element(int index)
        {
            return (seek(a, index), seek(b,index), seek(c,index));
        }

        [MethodImpl(Inline)]
        public  void Element(int index, (F a, F b, F c) x)
        {
            seek(a, index) = x.a;
            seek(b, index) = x.b; 
            seek(c, index) = x.c;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => a.Length;
        }

    }

    public readonly ref struct FixedIndex<F,T>
        where F : unmanaged, IFixed
        where T : unmanaged
    {
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
        public ref F Element(int index)
            => ref this[index];
        
        [MethodImpl(Inline)]
        public Span<F> ToSpan()
            => data;

        [MethodImpl(Inline)]
        public ReadOnlySpan<F> ToReadOnlySpan()
            => data;

        public F[] ToArray()
            => data.ToArray();
    }    
}