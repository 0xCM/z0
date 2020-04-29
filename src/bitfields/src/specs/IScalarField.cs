//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    /// <summary>
    /// Characterizes a bitfield defined over a numeric value
    /// </summary>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IScalarField<T> 
        where T : unmanaged
    {
        T Scalar {get;set;}        
    }
}