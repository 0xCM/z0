//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Characterises a type stratifier
    /// </summary>
    public interface ITypeKind : IKind
    {        

    }
    
    /// <summary>
    /// Characterizes a parametric type stratifier
    /// </summary>
    /// <typeparam name="K">The stratifying type</typeparam>
    public interface ITypeKind<K> : ITypeKind
    {

    }
}