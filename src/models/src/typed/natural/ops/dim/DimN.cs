//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static TypeNats;


    /// <summary>
    /// Defines a dimension axis which may represent the dimension of a vector of length N
    /// or the dimensions of a square matrix that contains N vectors of dimension N
    /// </summary>
    /// <typeparam name="N">The dimension type</typeparam>
    public readonly struct Dim<N> : IDim1
        where N : unmanaged, ITypeNat
    {
        public static implicit operator ulong(Dim<N> x)
            => x.I;
    
        /// <summary>
        /// The one-dimensional axis
        /// </summary>
        public ulong I 
            => value<N>();

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
            => new Dimensions(1, new ulong[]{value<N>()}, value<N>());
    }
}