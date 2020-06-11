//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    internal interface INativeNatural : ITypeNat
    {

    }
    
    /// <summary>
    /// Characterizes an atom of the type natural grammar
    /// </summary>
    /// <typeparam name="N">The reifying type</typeparam>
    public interface INatPrimitive<N> : INatNumber<N>
        where N : unmanaged, INatPrimitive<N>
    {
        
    }
}