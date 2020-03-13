//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    
    public readonly struct HomPoint<N,T> : IHomPoint<N,T>, IFormattable<HomPoint<N,T>>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {        
        public readonly T[] data;        

        public int Dimension 
        {
            get => Nats.natval<N>();
        }

        [MethodImpl(Inline)]
        internal HomPoint(T x0)
        {
            data = new T[]{x0};
        }

        [MethodImpl(Inline)]
        internal HomPoint(T x0, T x1)
        {
            data = new T[]{x0,x1};
        }

        [MethodImpl(Inline)]
        internal HomPoint(T x0, T x1, T x2)
        {
            data = new T[]{x0,x1,x2};
        }

        [MethodImpl(Inline)]
        
        internal HomPoint(UnaryPoint<T> src)
        {
            data = src.PointArray;
        }

        [MethodImpl(Inline)]
        internal HomPoint(BinaryPoint<T> src)
        {
            data = src.PointArray;            
        }

        [MethodImpl(Inline)]
        internal HomPoint(TernaryPoint<T> src)
        {
            data = src.PointArray;            
        }

        [MethodImpl(Inline)]
        internal HomPoint(N1 n, Span<T> src)
        {
            data = new T[]{skip(src,0)};
        }

        [MethodImpl(Inline)]
        internal HomPoint(N2 n, Span<T> src)
        {
            data = src.Slice(0,2).ToArray();
        }

        [MethodImpl(Inline)]
        internal HomPoint(N3 n, Span<T> src)
        {
            data = src.Slice(0,3).ToArray();
        }

        [MethodImpl(Inline)]
        internal HomPoint(N1 n, T[] src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        internal HomPoint(N2 n, T[] src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        internal HomPoint(N3 n, T[] src)
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


    public readonly struct UnaryPoint<T> : IHomPoint<N1,T>
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

    public readonly struct BinaryPoint<T> : IHomPoint<N2,T>
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

    public readonly struct TernaryPoint<T> : IHomPoint<N3,T>
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