//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

   /// <summary>
    /// Characterizes a higher-kinded type representation
    /// </summary>
    public interface ITypeKind : IHigherKind
    {        
    }
    
    public interface ITypeKind<T> : ITypeKind
    {

    }

    public interface ITypeKind<T1,T2> : ITypeKind
    {

    }

    public interface ITypeKind<T1,T2,T3> : ITypeKind
    {

    }

}