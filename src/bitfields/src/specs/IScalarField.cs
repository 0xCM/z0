//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Characterizes a bitfield defined over a numeric value
    /// </summary>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IScalarField<T> 
        where T : unmanaged
    {
        T Scalar {get;}    

        /// <summary>
        /// Updates the underlying scalar value
        /// </summary>
        /// <param name="src">The source data</param>
        ref readonly T Update(in T src); 
    }
}