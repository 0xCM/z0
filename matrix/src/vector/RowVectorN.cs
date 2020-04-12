//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public struct RowVector<N,T>  
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
         T[] data;

        /// <summary>
        /// The vector's dimension
        /// </summary>
        public static int Dim => nati<N>();     

        /// <summary>
        /// The zero vector
        /// </summary>
        public static RowVector<N,T> Zero => new RowVector<N,T>(new T[Dim]);
         
        [MethodImpl(Inline)]   
        public static implicit operator RowVector<T>(RowVector<N,T> src)
            => new RowVector<T>(src.data);

        [MethodImpl(Inline)]   
        public static implicit operator ReadOnlySpan<T>(RowVector<N,T> src)
            => src.data;

        [MethodImpl(Inline)]   
        public static implicit operator RowVector<N,T>(T[] src)
            => new RowVector<N, T>(src);

        [MethodImpl(Inline)]   
        public static implicit operator RowVector<N,T>(RowVector<T> src)
            => new RowVector<N, T>(src.Data);

        [MethodImpl(Inline)]
        public static bool operator == (RowVector<N,T> lhs, RowVector<N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (RowVector<N,T> lhs, RowVector<N,T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static T operator *(RowVector<N,T> lhs, RowVector<N,T> rhs)
            => gmath.dot<T>(lhs.Data, rhs.Data);         

        /// <summary>
        /// Initializes a vector with an array
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline)]
        public RowVector(T[] src)
        {
            require(src.Length >= Dim, $"{src.Length} < {Dim}");
            data = src;
        }
                    
        /// <summary>
        /// Queries/manipulates component values
        /// </summary>
        public ref T this[int index] 
        {
            [MethodImpl(Inline)]
            get => ref data[index];
        }

        /// <summary>
        /// The vector data
        /// </summary>
        public T[] Data
        {
            [MethodImpl(Inline)]
            get => data;
        }
 
        /// <summary>
        /// The count of vector components, otherwise known as its dimension
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Dim;
        }

        /// <summary>
        /// Projects the source vector onto a target vector of the same length 
        /// via a supplied transformation
        /// </summary>
        /// <param name="f">The transformation function</param>
        /// <typeparam name="U">The target vector element type</typeparam>
        [MethodImpl(Inline)]
        public RowVector<N,U> Map<U>(Func<T,U> f)
            where U:unmanaged
        {
            var dst = RowVector.alloc<N,U>();
            return Map(f, ref dst);
        }

        /// <summary>
        /// Projects the source vector onto a caller-supplied target vector of the same length 
        /// via a supplied transformation
        /// </summary>
        /// <param name="f">The transformation function</param>
        /// <typeparam name="U">The target vector element type</typeparam>
        public ref RowVector<N,U> Map<U>(Func<T,U> f, ref RowVector<N,U> dst)
            where U:unmanaged
        {
            for(var i=0; i < Length; i++)
                dst[i] = f(data[i]);
            return ref dst;
        }
        
        [MethodImpl(Inline)]
        public RowVector<N,U> Convert<U>()
            where U : unmanaged
               => new RowVector<N,U>(Cast.to<T,U>(data));

        public bool Equals(RowVector<N,T> rhs)
        {
            for(var i = 0; i<Dim; i++)
                if(gmath.neq(data[i], rhs.data[i]))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public ref RowVector<N,T> CopyTo(ref RowVector<N,T> dst)
        {
            data.CopyTo(dst.data);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public RowVector<N,T> Replicate()
            => new RowVector<N,T>(data.Replicate());

        [MethodImpl(Inline)]
        public string Format()
            => data.Format();    

        public override bool Equals(object rhs)
            => rhs is RowVector<N,T> x && Equals(x);

        public override int GetHashCode()
            => data.GetHashCode();
 
        public override string ToString()
            => Format();    
    }
}