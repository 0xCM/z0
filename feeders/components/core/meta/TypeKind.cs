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
    /// Characterizes parametric kind partitions
    /// </summary>
    /// <typeparam name="K">The partitioning type</typeparam>
    public interface ITypeKind<K> : ITypeKind
    {

    }

    public interface IOpKind : IKind
    {
        OpKindId KindId {get;}
    }
}