//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;     

    /// <summary>
    /// Defines a rectangular dimension
    /// </summary>
    public readonly struct Dim2 : IDim2
    {
        /// <summary>
        /// The first axis, e.g. the x-axis
        /// </summary>
        public readonly ulong I;

        /// <summary>
        /// The second axis, e.g. the y-axis
        /// </summary>
        public readonly ulong J;
                
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

        /// <summary>
        /// The volume bound by the rectangle defined by the two axes
        /// </summary>
        public ulong Volume
        {
            [MethodImpl(Inline)]
            get => I * J;
        }

        /// <summary>
        /// Returns the axis corresponding to its 0-based index
        /// </summary>
        public ulong this[int axis]            
        {
            [MethodImpl(Inline)]
            get => axis == 0 ? I :  axis == 1 ? J :  0;
        }

        /// <summary>
        /// The axis count - 2
        /// </summary>
        public int Order 
        {
            [MethodImpl(Inline)]
            get => 2;
        }

        ulong IDim2.I => I;

        ulong IDim2.J => J;

        public string Format()
            => $"{I}×{J}";

        public override string ToString()
            => Format();

        public DimInfo Describe()
            => new DimInfo(Order, new ulong[]{I, J}, Volume);
            
        public override int GetHashCode()
            => HashCode.Combine(I,J);

        public bool Equals(Dim2 y)
            => this.I == y.I && this.J == y.J;

        public override bool Equals(object y)
            => y is Dim2 d && Equals(d);

        [MethodImpl(Inline)]
        static Dim2 Define(ulong i, ulong j)
            => new Dim2(i,j);
    }

    /// <summary>
    /// Defines a rectangular dimension
    /// </summary>
    /// <typeparam name="M">The type of the first dimension</typeparam>
    /// <typeparam name="N">The type of the second dimension</typeparam>
    public readonly struct Dim<M,N> : IDim2, IDim<M,N>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
    {        
        [MethodImpl(Inline)]
        public static implicit operator (ulong i, ulong j)(Dim<M,N> x)
            => (TypeNats.value<M>(), TypeNats.value<N>());

        [MethodImpl(Inline)]
        public static implicit operator (int i, int j)(Dim<M,N> x)
            => ((int)TypeNats.value<M>(), (int)TypeNats.value<N>());

        [MethodImpl(Inline)]
        public static implicit operator Dim2(Dim<M,N> x)
            => new Dim2(x.I, x.J);

        [MethodImpl(Inline)]
        public static implicit operator DimK(Dim<M,N> x)
            => new DimK(x.I, x.J);

        /// <summary>
        /// Specifies the first component of the dimension
        /// </summary>
        public ulong I => value<M>();
        
        /// <summary>
        /// Specifies the second component of the dimension
        /// </summary>
        public ulong J => value<N>();

        /// <summary>
        /// The volume bound by the rectangle defined by the two axes
        /// </summary>
        public ulong Volume => NatCalc.mul<M,N>();
            
        /// <summary>
        /// Returns the axis corresponding to its 0-based index
        /// </summary>
        public ulong this[int axis]
        {
            [MethodImpl(Inline)]
            get => axis == 0 ? I  :  axis == 1 ? J :  0;
        }

        /// <summary>
        /// The axis count - 2
        /// </summary>
        public int Order 
        {
            [MethodImpl(Inline)]
            get => 2;
        }

        public string Format()
            => $"{I}×{J}";
 
        public override string ToString()
            => Format();

        public override int GetHashCode()
            => HashCode.Combine(I,J);

        public bool Equals(Dim<M,N> y)
            => this.I == y.I && this.J == y.J;

        public override bool Equals(object y)
            => y is Dim<M,N> d && Equals(d);

        public DimInfo Describe()
            => new DimInfo(2, new ulong[]{I, J}, Volume);
    }
}