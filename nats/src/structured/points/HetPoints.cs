//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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


    public readonly ref struct Points<X0,X1>
        where X0 : unmanaged
        where X1 : unmanaged
    {
        readonly Span<Point<X0,X1>> Data;
        
        [MethodImpl(Inline)]
        public static implicit operator Points<X0,X1>(Point<X0,X1>[] src)
            => new Points<X0,X1>(src);

        [MethodImpl(Inline)]
        public static implicit operator Points<X0,X1>(Span<Point<X0,X1>> src)
            => new Points<X0,X1>(src);

        [MethodImpl(Inline)]
        public static implicit operator Points<Point<X0,X1>>(Points<X0,X1> src)
            => src.Cellularize();

        [MethodImpl(Inline)]
        public Points(Point<X0,X1>[] src)
        {
            this.Data = src;
        }

        [MethodImpl(Inline)]
        public Points(Span<Point<X0,X1>> src)
        {
            this.Data = src;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        [MethodImpl(Inline)]
        public ref Point<X0,X1> Point(int index)
            => ref seek(Data, index);

        public ref Point<X0,X1> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Point(index);
        }


        [MethodImpl(Inline)]
        public Span<T> Linearize<T>()
            where T : unmanaged
                => Data.As<Point<X0,X1>,T>();

        [MethodImpl(Inline)]
        public Points<Point<X0,X1>> Cellularize()
            => Data;
    }

    public readonly ref struct Points<X0,X1,X2>
        where X0 : unmanaged
        where X1 : unmanaged
        where X2 : unmanaged
    {
        readonly Span<Point<X0,X1,X2>> Data;        

        [MethodImpl(Inline)]
        public static implicit operator Points<X0,X1,X2>(Point<X0,X1,X2>[] src)
            => new Points<X0,X1,X2>(src);

        [MethodImpl(Inline)]
        public static implicit operator Points<X0,X1,X2>(Span<Point<X0,X1,X2>> src)
            => new Points<X0,X1,X2>(src);

        [MethodImpl(Inline)]
        public static implicit operator Points<Point<X0,X1,X2>>(Points<X0,X1,X2> src)
            => src.Cellularize();

        [MethodImpl(Inline)]
        public Points(Point<X0,X1,X2>[] src)
        {
            this.Data = src;
        }

        [MethodImpl(Inline)]
        public Points(Span<Point<X0,X1,X2>> src)
        {
            this.Data = src;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        [MethodImpl(Inline)]
        public ref Point<X0,X1,X2> Point(int index)
            => ref seek(Data, index);

        public ref Point<X0,X1,X2> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Point(index);
        }


        [MethodImpl(Inline)]
        public Span<T> Linearize<T>()
            where T : unmanaged
                => Data.As<Point<X0,X1,X2>,T>();

        [MethodImpl(Inline)]
        public Points<Point<X0,X1,X2>> Cellularize()
            => Data;
    }
}