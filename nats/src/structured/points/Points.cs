//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;
    using static refs;

    public readonly ref struct Points<P>
        where P : IPointCell<P>
    {
        readonly Span<P> points;

        [MethodImpl(Inline)]
        public static implicit operator Points<P>(P[] src)
            => new Points<P>(src);

        [MethodImpl(Inline)]
        public static implicit operator Points<P>(Span<P> src)
            => new Points<P>(src);

        [MethodImpl(Inline)]
        public Points(Span<P> points)
        {
            this.points = points;
        }

        [MethodImpl(Inline)]
        public Points(P[] points)
        {
            this.points = points;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => points.Length;
        }

        [MethodImpl(Inline)]
        public ref P Point(int index)
            => ref seek(points, index);

        public ref P this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Point(index);
        }

        [MethodImpl(Inline)]
        public Span<P> ToSpan()
            => points;

        [MethodImpl(Inline)]
        public P[] ToArray()
            => points.ToArray();
    }

    public readonly ref struct Points<N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        readonly Span<Point<N,T>> Data;

        [MethodImpl(Inline)]
        public static implicit operator Points<N,T>(Span<Point<N,T>> src)
            => new Points<N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Points<N,T>(Point<N,T>[] src)
            => new Points<N,T>(src);

        [MethodImpl(Inline)]
        public Points(Span<Point<N,T>> data)
        {
            this.Data = data;
        }

        [MethodImpl(Inline)]
        public ref Point<N,T> Point(int index)
            => ref seek(Data, index);

        public ref Point<N,T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Point(index);
        }        

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}