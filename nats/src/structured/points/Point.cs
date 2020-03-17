//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Point<N,T> : IPoint<N,T>, IFormattable<Point<N,T>>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {        
        public readonly T[] data;        

        public ref T this[N0 n]
        {
            get => ref data[0];
        }

        public ref T this[N1 n]
        {
            get => ref data[1];
        }

        public ref T this[N2 n]
        {
            get => ref data[2];
        }

        public ref T this[N3 n]
        {
            get => ref data[3];
        }

        public static implicit operator Point<N,T>(MixedPoint<T,T,T> src)
            => new Point<N,T>(src.x0, src.x1, src.x2);
    
        [MethodImpl(Inline)]
        public static implicit operator Point<N,T>(T x)
            => new Point<N,T>(x);         

        [MethodImpl(Inline)]
        public static implicit operator Point<N,T>((T x0, T x1) x)
            => new Point<N,T>(x);         

        [MethodImpl(Inline)]
        public static implicit operator Point<N,T>((T x0, T x1, T x2) src)
            => new Point<N,T>(src.x0, src.x1, src.x2);

        [MethodImpl(Inline)]
        public static implicit operator Point<N,T>((T x0, T x1, T x2, T x3) src)
            => new Point<N,T>(src.x0, src.x1, src.x2, src.x3);

        public int Dimension 
        {
            [MethodImpl(Inline)]
            get => Nats.natval<N>();
        }

        [MethodImpl(Inline)]
        internal Point(T x0)
        {
            data = new T[]{x0};
        }

        [MethodImpl(Inline)]
        internal Point(T x0, T x1)
        {
            data = new T[]{x0,x1};
        }

        [MethodImpl(Inline)]
        internal Point(T x0, T x1, T x2)
        {
            data = new T[]{x0,x1,x2};
        }

        [MethodImpl(Inline)]
        internal Point(T x0, T x1, T x2, T x3)
        {
            data = new T[]{x0,x1,x2,x3};
        }

        [MethodImpl(Inline)]
        
        internal Point(UnaryPoint<T> src)
        {
            data = src.PointArray;
        }

        [MethodImpl(Inline)]
        internal Point(BinaryPoint<T> src)
        {
            data = src.PointArray;            
        }

        [MethodImpl(Inline)]
        internal Point(TernaryPoint<T> src)
        {
            data = src.PointArray;            
        }

        [MethodImpl(Inline)]
        internal Point(N1 n, Span<T> src)
        {
            data = new T[]{skip(src,0)};
        }

        [MethodImpl(Inline)]
        internal Point(N2 n, Span<T> src)
        {
            data = src.Slice(0,2).ToArray();
        }

        [MethodImpl(Inline)]
        internal Point(N3 n, Span<T> src)
        {
            data = src.Slice(0,3).ToArray();
        }

        [MethodImpl(Inline)]
        internal Point(N1 n, T[] src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        internal Point(N2 n, T[] src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        internal Point(N3 n, T[] src)
        {
            data = src;
        }

        public Span<T> Components 
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public string Format()
            => text.parenthetical(string.Join(',',data));
        
        public override string ToString()
            => Format();         
    }
}