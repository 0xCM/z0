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
        public readonly ulong I;

        public readonly ulong J;
        
        [MethodImpl(Inline)]
        public static Dim2 Define(ulong i, ulong j)
            => new Dim2(i,j);

        [MethodImpl(Inline)]
        public static implicit operator Dim2((ulong i, ulong j) x)
            => Define(x.i,x.j);

        [MethodImpl(Inline)]
        public static implicit operator Dim2((uint i, uint j) x)
            => Define(x.i,x.j);

        [MethodImpl(Inline)]
        public static implicit operator Dim2((int i, int j) x)
            => Define((ulong)x.i,(ulong)x.j);

        [MethodImpl(Inline)]
        public Dim2(ulong I, ulong J)
        {
            this.I = I;
            this.J = J;
        }

        public ulong Volume
        {
            [MethodImpl(Inline)]
            get => I * J;
        }

        public ulong this[int axis]            
        {
            [MethodImpl(Inline)]
            get => axis == 0 ? I :  axis == 1 ? J :  0;
        }

        public int Order 
        {
            [MethodImpl(Inline)]
            get => 2;
        }

        public DimInfo Describe()
            => new DimInfo(Order, new ulong[]{I, J}, Volume);
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

        [MethodImpl(Inline)]
        public static implicit operator (ulong i, ulong j)(Dim<M,N> x)
            => Nat.pair<M,N>();

        [MethodImpl(Inline)]
        public static implicit operator (int i, int j)(Dim<M,N> x)
            => Nat.pairi<M,N>();

        [MethodImpl(Inline)]
        public static implicit operator Dim2(Dim<M,N> x)
            => new Dim2(x.I, x.J);

        [MethodImpl(Inline)]
        public static implicit operator DimK(Dim<M,N> x)
            => new DimK(x.I, x.J);

        /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public ulong I => natu<M>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public ulong J => natu<N>();

        public ulong Volume => NatMath.mul<M,N>();
            
        public ulong this[int axis]
        {
            [MethodImpl(Inline)]
            get => axis == 0 ? I  :  axis == 1 ? J :  0;
        }

        public int Order 
        {
            [MethodImpl(Inline)]
            get => 2;
        }

        public string Format()
            => $"{I}×{J}";
 
        public override string ToString()
            => Format();

        public DimInfo Describe()
            => new DimInfo(2, new ulong[]{I, J}, Volume);

    }

}