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
    /// Metatype stratification
    /// </summary>
    public interface IKind
    {
        
    }

    /// <summary>
    /// Characterizes type classifiers predicated on enumerations
    /// </summary>
    /// <typeparam name="E">The enum type defining potential classifications</typeparam>
    public interface IKind<E> : IKind
        where E : unmanaged, Enum
    {
        E Class {get;}

        string Name => Class.ToString();
    }

    public interface IKind<K,E> : IKind<E>
        where K : unmanaged, IKind<K,E>
        where E : unmanaged, Enum
    {

    }

    public interface IKind<K,E,T> : IKind<K,E>
        where K : unmanaged, IKind<K,E>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        NK<T> NK => default;
    }

    public interface ITypeKind : IKind
    {        
    }
    
    /// <summary>
    /// Type kinds are classified by types other than enumerations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITypeKind<T> : ITypeKind
    {

    }

    public interface ITypeKind<T1,T2> : ITypeKind
    {

    }
}