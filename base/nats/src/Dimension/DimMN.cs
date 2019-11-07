//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static nfunc;
    using static constant;     

    /// <summary>
    /// Specifies a rectangular dimension
    /// </summary>
    public readonly struct Dim2 : IDim
    {
        
        [MethodImpl(Inline)]
        public static Dim2 Define(ulong i, ulong j)
            => new Dim2(i,j);

        [MethodImpl(Inline)]
        public static Dim2 Define(int i, int j)
            => new Dim2((ulong)i,(ulong)j);

        [MethodImpl(Inline)]
        public static implicit operator Dim2((ulong i, ulong j) x)
            => Define(x.i,x.j);

        [MethodImpl(Inline)]
        public static implicit operator Dim2((uint i, uint j) x)
            => Define(x.i,x.j);

        [MethodImpl(Inline)]
        public static implicit operator Dim2((int i, int j) x)
            => Define((ulong)x.i,(ulong)x.j);

        public readonly ulong I;

        public readonly ulong J;

        [MethodImpl(Inline)]
        public static implicit operator DimInfo(Dim2 src)
            => new DimInfo(src.Order, new ulong[]{src.I, src.J}, src.Volume);

        [MethodImpl(Inline)]
        public Dim2(ulong I, ulong J)
        {
            this.I = I;
            this.J = J;
        }

        public ulong Volume
            => I * J;

        public ulong this[int axis]            
            => axis == 0 ? I 
            :  axis == 1 ? J
            :  0;

        public int Order 
            => 2;

    }


    /// <summary>
    /// Defines a rectangular dimension
    /// </summary>
    /// <typeparam name="M">The type of the first dimension</typeparam>
    /// <typeparam name="N">The type of the second dimension</typeparam>
    public readonly struct Dim<M,N> : IDim
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
    {
        public static Dim<M,N> Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator (ulong i, ulong j)(Dim<M,N> x)
            => Nat.pair<M,N>();

        [MethodImpl(Inline)]
        public static implicit operator (int i, int j)(Dim<M,N> x)
            => Nat.pairi<M,N>();

        [MethodImpl(Inline)]
        public static implicit operator DimInfo(Dim<M,N> src)
            => new DimInfo(2, new ulong[]{natu<M>(), natu<N>()}, natu<M>() * natu<N>());

        [MethodImpl(Inline)]
        public static implicit operator Dim2(Dim<M,N> x)
            => new Dim2(x.I, x.J);

        [MethodImpl(Inline)]
        public static implicit operator DimK(Dim<M,N> x)
            => new DimK(x.I, x.J);

        /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public ulong I 
            => natu<M>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public ulong J 
            => natu<N>();

        public ulong Volume
            => I*J;

        public ulong this[int axis]
            => axis == 0 ? I 
            :  axis == 1 ? J
            :  0;

        public int Order 
            => 2;

        public string Format()
            => $"{I}×{J}";
 
        public override string  ToString()
            => Format();

        public T[] alloc<T>()
            => new T[Volume];
    }




}