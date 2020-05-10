//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes a type with which a number of parametric type is associated
    /// </summary>
    /// <typeparam name="N">The natural number type</typeparam>
    public interface INaturalized<N>
        where N : unmanaged, ITypeNat
    {
        
    }
}