//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TernaryPoint<T> : IPoint<N3,T>
        where T : unmanaged
    {
        public readonly T x0;

        public readonly T x1;

        public readonly T x2;

        internal T[] PointArray
        {
            [MethodImpl(Inline)]
            get => new T[]{x0,x1,x2};
        }

        public Span<T> Components 
        {
            [MethodImpl(Inline)]
            get => PointArray;
        }

        [MethodImpl(Inline)]
        public static implicit operator TernaryPoint<T>((T x0, T x1, T x2) src)
            => new TernaryPoint<T>(src.x0, src.x1, src.x2);             

        [MethodImpl(Inline)]
        public static implicit operator (T x0, T x1, T x2)(TernaryPoint<T> src)
            => (src.x0, src.x1, src.x2);

        [MethodImpl(Inline)]
        public static implicit operator Point<N3,T>(TernaryPoint<T> src)
            => (src.x0, src.x1, src.x2);

        [MethodImpl(Inline)]
        public static implicit operator TernaryPoint<T>(Point<N3,T> src)
            => new TernaryPoint<T>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator TernaryPoint<T>(Span<T> src)
            => new TernaryPoint<T>(src);             

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(TernaryPoint<T> src)
            => src.Components;

        [MethodImpl(Inline)]
        public TernaryPoint(Span<T> src)
        {
            this.x0 = skip(src,0);
            this.x1 = skip(src,1);
            this.x2 = skip(src,2);
        }

        [MethodImpl(Inline)]
        public TernaryPoint(T x0, T x1, T x2)
        {
            this.x0 = x0;
            this.x1 = x1;
            this.x2 = x2;
        }

        public void Deconstruct(out T x0, out T x1, out T x2)
        {
            x0 = this.x0;
            x1 = this.x1;
            x2 = this.x2;
        }

        public string Format()
            => text.parenthetical(text.comma(), x0, x1, x2);

        public override string ToString()
            => Format();
    }    
}