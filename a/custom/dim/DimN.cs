//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Core;

    /// <summary>
    /// Specifies a dimension with one axis
    /// </summary>
    public readonly struct Dim1 : IDim1
    {
        public readonly ulong I;

        public static implicit operator DimInfo(Dim1 src)
            => new DimInfo(src.Order, new ulong[]{src.I}, src.Volume);

        public Dim1(ulong I)
        {
            this.I = I;
        }

        public ulong Volume
            => I;

        public ulong this[int axis]            
            => axis == 0 ? I : 0;
        
        public int Order 
            => 1;

        ulong IDim1.I => I;

        public string Format()
            => $"{I}";

        public override string ToString()
            => Format();

        public DimInfo Describe()
            => new DimInfo(Order, new ulong[]{I}, Volume);
    }

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
    
        public static implicit operator Dim1(Dim<N> x)
            => new Dim1(x.I);

        public static implicit operator DimK(Dim<N> x)
            => new DimK(x.I);

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

        public DimInfo Describe()
            => new DimInfo(1, new ulong[]{value<N>()}, value<N>());
    }
}