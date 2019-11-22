//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    /// <summary>
    /// Defines the algebraic dual to a vector; in practice, covectors represent
    /// rows in a matrix while vectors represent columns. This duality captures the
    /// salient distinction between row and column-major matrix storage
    /// </summary>
    public struct Covector<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        T[] data;

        [MethodImpl(Inline)]
        public static Covector<N,T> Load(T[] src)
            => new Covector<N,T>(src);

        /// <summary>
        /// Specifies the length of the vector, i.e. its component count
        /// </summary>
        public static readonly int Length = nati<N>();     

        [MethodImpl(Inline)]
        public static bool operator == (Covector<N,T> lhs, Covector<N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Covector<N,T> lhs, Covector<N,T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        Covector(T[] src)
        {
            data = src;
        }
        
        public ref T this[int index] 
            => ref data[index];

        public Span<T> Span
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public Vector<N,T> Transpose()
            => Vector.load<N,T>(data);
 
        public bool Equals(Covector<N,T> rhs)
        {
            var lhsData = Span;
            var rhsData = rhs.Span;
            for(var i = 0; i<lhsData.Length; i++)
                if(gmath.neq(lhsData[i], rhsData[i]))
                    return false;
            return true;
        }

        public override bool Equals(object rhs)
            => rhs is Covector<N,T> x && Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();
 
    }
}

