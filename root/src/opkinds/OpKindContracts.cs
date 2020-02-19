//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

    /// <summary>
    /// Characterizes a type that represents an operation kind
    /// </summary>
    public interface IOpKind
    {
        string Name {get;}
    }

    /// <summary>
    /// Characterizes a type that represents an enum-classified operation kind
    /// </summary>
    public interface IOpKind<E> : IOpKind
        where E : unmanaged, Enum
    {
        E Kind {get;}

        string IOpKind.Name => Kind.ToString().ToLower();        
    }
     
    /// <summary>
    /// Characterizes a reification that represents an enum-classified operation kind
    /// </summary>
    public interface IOpKind<K,E> : IOpKind<E>
        where E : unmanaged, Enum
        where K : unmanaged, IOpKind<K,E>
    {        
        
    }    
}