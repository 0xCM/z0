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

    public readonly struct UnaryPoint<T> : IPoint<N1,T>
        where T : unmanaged
    {
        public readonly T x0;

        internal T[] PointArray
        {
            [MethodImpl(Inline)]
            get => new T[]{x0};
        }

        public Span<T> Components 
        {
            [MethodImpl(Inline)]
            get => PointArray;
        }

        [MethodImpl(Inline)]
        public static implicit operator UnaryPoint<T>(T src)
            => new UnaryPoint<T>(src);             

        [MethodImpl(Inline)]
        public static implicit operator T(UnaryPoint<T> src)
            => src.x0;

        [MethodImpl(Inline)]
        public static implicit operator UnaryPoint<T>(Point<N1,T> src)
            => new UnaryPoint<T>(src.data);             

        [MethodImpl(Inline)]
        public static implicit operator Point<N1,T>(UnaryPoint<T> src)
            => new Point<N1, T>(src.x0);

        [MethodImpl(Inline)]
        public static implicit operator UnaryPoint<T>(Span<T> src)
            => new UnaryPoint<T>(src);             

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(UnaryPoint<T> src)
            => src.Components;

        [MethodImpl(Inline)]
        public UnaryPoint(Span<T> src)
        {
            this.x0 = skip(src,0);
        }

        [MethodImpl(Inline)]
        public UnaryPoint(T x0)
        {
            this.x0 = x0;
        }

        public void Deconstruct(out T x0)
        {
            x0 = this.x0;
        }

        public string Format()
            => text.parenthetical(text.comma(), x0);

        public override string ToString()
            => Format();
    }    
}