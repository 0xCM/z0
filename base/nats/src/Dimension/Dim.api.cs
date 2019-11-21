//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;

    public static class Dim
    {
        /// <summary>
        /// Constructs an natural dimension of order 1
        /// </summary>
        /// <typeparam name="N">The axis type</typeparam>
        [MethodImpl(Inline)]
        public static Dim<N> Define<N>()
            where N : unmanaged, ITypeNat
                => default;

        /// <summary>
        /// Constructs an natural dimension of order 2
        /// </summary>
        /// <typeparam name="M">The type of the first axis</typeparam>
        /// <typeparam name="N">The type of the second axis</typeparam>
        [MethodImpl(Inline)]
        public static Dim<M,N> Define<M,N>()
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => default;

        /// <summary>
        /// Constructs an natural dimension of order 3
        /// </summary>
        /// <typeparam name="M">The type of the first axis</typeparam>
        /// <typeparam name="N">The type of the second axis</typeparam>
        /// <typeparam name="P">The type of the third axis</typeparam>
        [MethodImpl(Inline)]
        public static Dim<M,N,P> Define<M,N,P>()
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where P : unmanaged, ITypeNat
                => default;

        /// <summary>
        /// Defines a dimension of order 1
        /// </summary>
        /// <param name="i">The length of the first axis</param>
        [MethodImpl(Inline)]
        public static Dim1 Define(ulong i)
            => new Dim1(i);

        /// <summary>
        /// Defines a dimension of order 2 
        /// </summary>
        /// <param name="i">The length of the first axis</param>
        [MethodImpl(Inline)]
        public static Dim2 Define(ulong i, ulong j)
            => new Dim2(i, j);

        /// <summary>
        /// Defines a dimension of order 3 
        /// </summary>
        /// <param name="i">The length of the first axis</param>
        public static Dim3 Define(ulong i, ulong j, ulong k)
            => new Dim3(i, j, k);


        /// <summary>
        /// Constructs a dimension of arbitrary order
        /// </summary>
        /// <param name="axes">The axes that comprise the dimension</param>
        public static DimK Define(params ulong[] axes)
            => new DimK(axes);

    }


}