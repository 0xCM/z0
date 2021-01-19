//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static TypeNats;
    using static  Part;

    /// <summary>
    /// Defines a dimension axis which may represent the dimension of a vector of length N
    /// or the dimensions of a square matrix that contains N vectors of dimension N
    /// </summary>
    /// <typeparam name="N">The dimension type</typeparam>
    public readonly struct Dim<N> : IDim1
        where N : unmanaged, ITypeNat
    {
        /// <summary>
        /// The one-dimensional axis
        /// </summary>
        public ulong I
            => nat64u<N>();

        public ulong Volume
            => I;

        public ulong this[int axis]
            => axis == 0 ? I : 0;

        public int Order
            => 1;

        public string Format()
            => $"{I}";

        public override string ToString()
            => Format();

        public Dimensions Describe()
            => new Dimensions(1, new ulong[]{nat64u<N>()}, nat64u<N>());

        public static implicit operator ulong(Dim<N> x)
            => x.I;
    }
}