//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using PC = ParameterClass;

    public enum ParamKindAspect : uint
    {
        None = 0,
    
        /// <summary>
        /// Classifies parameters of numeric type
        /// </summary>
        Numeric = PC.Numeric,

        /// <summary>
        /// Classifies parameters of blocked type
        /// </summary>
        Blocked = PC.Blocked,

        /// <summary>
        /// Classifies paramters of fixed kind
        /// </summary>
        Fixed = PC.Fixed,

        /// <summary>
        /// Classifies paramters of vectorized kind
        /// </summary>
        CpuVector = PC.CpuVector,

        /// <summary>
        /// Classifies paramters of bitvector kind
        /// </summary>
        BitVector = PC.BitVector,

        /// <summary>
        /// Classifies paramters of bitmatrix kind
        /// </summary>
        BitMatrix = PC.BitMatrix,

        /// <summary>
        /// Classifies paramters of bitgrid kind
        /// </summary>
        BitGrid = PC.BitGrid
    } 
}