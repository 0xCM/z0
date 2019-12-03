//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static nfunc;
    using static constant;     
 
    /// <summary>
    /// Defines a cubical dimension
    /// </summary>
    public readonly struct Dim3 : IDim3
    {
        /// <summary>
        /// The first axis, e.g. the x-axis
        /// </summary>
        public readonly ulong I;

        /// <summary>
        /// The first axis, e.g. the y-axis
        /// </summary>
        public readonly ulong J;

        /// <summary>
        /// The first axis, e.g. the z-axis
        /// </summary>
        public readonly ulong K;

        [MethodImpl(Inline)]
        public Dim3(ulong I, ulong J, ulong K)
        {
            this.I = I;
            this.J = J;
            this.K = K;
        }

        public ulong Volume
            => I * J * K;

        /// <summary>
        /// Returns the axis corresponding to its 0-based index
        /// </summary>
        public ulong this[int axis] 
        {           
            [MethodImpl(Inline)]
            get => 
               axis == 0 ? I 
            :  axis == 1 ? J
            :  axis == 2 ? K
            :  0;
        }

        /// <summary>
        /// The axis count - 3
        /// </summary>
        public int Order 
        {
            [MethodImpl(Inline)]
            get => 3;
        }

        ulong IDim3.I => I;

        ulong IDim3.J => J;

        ulong IDim3.K => K;

        public DimInfo Describe()
            => new DimInfo(Order, new ulong[]{I, J, K}, Volume);
        public string Format()
            => $"{I}×{J}×{K}";

        public override string ToString()
            => Format();
    }

    /// <summary>
    /// Defines a cubical dimension
    /// </summary>
    /// <typeparam name="M">The type of the first dimension</typeparam>
    /// <typeparam name="N">The type of the second dimension</typeparam>
    /// <typeparam name="P">The type of the third dimension</typeparam>
    public readonly struct Dim<M,N,P> : IDim3
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where P : unmanaged, ITypeNat
    {
        public static Dim<M,N,P> Rep => default;

        public static implicit operator Dim3(Dim<M,N,P> x)
            => new Dim3(x.I, x.J, x.K);

        public static implicit operator DimK(Dim<M,N,P> x)
            => new DimK(x.I, x.J, x.J);

        /// <summary>
        /// The first axis, e.g. the x-axis
        /// </summary>
        public ulong I 
        {
            [MethodImpl(Inline)]
            get => natu<M>();
        }
        
        /// <summary>
        /// The first axis, e.g. the y-axis
        /// </summary>
        public ulong J 
        {
            [MethodImpl(Inline)]
            get => natu<N>();
        }

        /// <summary>
        /// The first axis, e.g. the z-axis
        /// </summary>
        public ulong K 
        {
            [MethodImpl(Inline)]
            get => natu<P>();
        }

        /// <summary>
        /// The volume bound by the box defined by the three axes
        /// </summary>
        public ulong Volume
        {
            [MethodImpl(Inline)]
            get => NatMath.mul<M,N,P>();
        }

        /// <summary>
        /// Returns the axis corresponding to its 0-based index
        /// </summary>
        public ulong this[int axis]   
        {         
            [MethodImpl(Inline)]
            get => 
               axis == 0 ? natu<M>() 
            :  axis == 1 ? natu<N>()
            :  axis == 2 ? natu<P>()
            :  0;
        }

        /// <summary>
        /// The axis count - 3
        /// </summary>
        public int Order 
        {
            [MethodImpl(Inline)]
            get => 3;
        }

        public string Format()
            => $"{I}×{J}×{K}";

        public override string ToString()
            => Format();

        public DimInfo Describe()
            => new DimInfo(3, new ulong[]{natu<M>(), natu<N>(), natu<P>()}, Volume);
    }
}