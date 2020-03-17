//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly ref struct MixedPoints<X0,X1>
        where X0 : unmanaged
        where X1 : unmanaged
    {
        readonly Span<MixedPoint<X0,X1>> Data;
        
        [MethodImpl(Inline)]
        public static implicit operator MixedPoints<X0,X1>(MixedPoint<X0,X1>[] src)
            => new MixedPoints<X0,X1>(src);

        [MethodImpl(Inline)]
        public static implicit operator MixedPoints<X0,X1>(Span<MixedPoint<X0,X1>> src)
            => new MixedPoints<X0,X1>(src);

        [MethodImpl(Inline)]
        public static implicit operator Points<MixedPoint<X0,X1>>(MixedPoints<X0,X1> src)
            => src.Cellularize();

        [MethodImpl(Inline)]
        public MixedPoints(MixedPoint<X0,X1>[] src)
        {
            this.Data = src;
        }

        [MethodImpl(Inline)]
        public MixedPoints(Span<MixedPoint<X0,X1>> src)
        {
            this.Data = src;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        [MethodImpl(Inline)]
        public ref MixedPoint<X0,X1> Point(int index)
            => ref seek(Data, index);

        public ref MixedPoint<X0,X1> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Point(index);
        }

        [MethodImpl(Inline)]
        public Span<T> Linearize<T>()
            where T : unmanaged
                => Data.As<MixedPoint<X0,X1>,T>();

        [MethodImpl(Inline)]
        public Points<MixedPoint<X0,X1>> Cellularize()
            => Data;
    }

    public readonly ref struct MixedPoints<X0,X1,X2>
        where X0 : unmanaged
        where X1 : unmanaged
        where X2 : unmanaged
    {
        readonly Span<MixedPoint<X0,X1,X2>> Data;        

        [MethodImpl(Inline)]
        public static implicit operator MixedPoints<X0,X1,X2>(MixedPoint<X0,X1,X2>[] src)
            => new MixedPoints<X0,X1,X2>(src);

        [MethodImpl(Inline)]
        public static implicit operator MixedPoints<X0,X1,X2>(Span<MixedPoint<X0,X1,X2>> src)
            => new MixedPoints<X0,X1,X2>(src);

        [MethodImpl(Inline)]
        public static implicit operator Points<MixedPoint<X0,X1,X2>>(MixedPoints<X0,X1,X2> src)
            => src.Cellularize();

        [MethodImpl(Inline)]
        public MixedPoints(MixedPoint<X0,X1,X2>[] src)
        {
            this.Data = src;
        }

        [MethodImpl(Inline)]
        public MixedPoints(Span<MixedPoint<X0,X1,X2>> src)
        {
            this.Data = src;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        [MethodImpl(Inline)]
        public ref MixedPoint<X0,X1,X2> Point(int index)
            => ref seek(Data, index);

        public ref MixedPoint<X0,X1,X2> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Point(index);
        }


        [MethodImpl(Inline)]
        public Span<T> Linearize<T>()
            where T : unmanaged
                => Data.As<MixedPoint<X0,X1,X2>,T>();

        [MethodImpl(Inline)]
        public Points<MixedPoint<X0,X1,X2>> Cellularize()
            => Data;
    }
}