//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ITypeKind : IKind
    {        

    }
    
    /// <summary>
    /// Type kinds are partitioned by types thar are not enumerations
    /// </summary>
    /// <typeparam name="K"></typeparam>
    public interface ITypeKind<K> : ITypeKind
    {

    }

}