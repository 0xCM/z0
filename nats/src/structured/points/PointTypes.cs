//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    
    public readonly struct BinaryPoint<T> : IPoint<N2,T>
        where T : unmanaged
    {
        public readonly T x0;

        public readonly T x1;

        internal T[] PointArray
        {
            [MethodImpl(Inline)]
            get => new T[]{x0,x1};
        }

        public Span<T> Components 
        {
            [MethodImpl(Inline)]
            get => PointArray;
        }

        [MethodImpl(Inline)]
        public static implicit operator BinaryPoint<T>((T x0, T x1) src)
            => new BinaryPoint<T>(src.x0, src.x1);             

        [MethodImpl(Inline)]
        public static implicit operator (T x0, T x1)( BinaryPoint<T> src)
            => (src.x0, src.x1);

        [MethodImpl(Inline)]
        public static implicit operator Point<N2,T>(BinaryPoint<T> src)
            => (src.x0, src.x1);

        [MethodImpl(Inline)]
        public static implicit operator BinaryPoint<T>(Point<N2,T> src)
            => new BinaryPoint<T>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BinaryPoint<T>(Span<T> src)
            => new BinaryPoint<T>(src);             

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(BinaryPoint<T> src)
            => src.Components;

        [MethodImpl(Inline)]
        public BinaryPoint(Span<T> src)
        {
            this.x0 = skip(src,0);
            this.x1 = skip(src,1);
        }

        [MethodImpl(Inline)]
        public BinaryPoint(T x0, T x1)
        {
            this.x0 = x0;
            this.x1 = x1;
        }

        public void Deconstruct(out T x0, out T x1)
        {
            x0 = this.x0;
            x1 = this.x1;
        }

        public string Format()
            => text.parenthetical(text.comma(), x0, x1);

        public override string ToString()
            => Format();
    }    
}