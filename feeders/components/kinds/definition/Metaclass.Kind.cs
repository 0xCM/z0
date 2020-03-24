//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Metaclass stratification
    /// </summary>
    public interface IKind : IClassifier
    {
        
    }

    /// <summary>
    /// Kind reification
    /// </summary>
    public interface IKind<K> : IKind
        where K : IKind<K>, new()
    {

    }

     public interface ILiteralKind<E> : IKind, ITypeLevelEnum<E>
        where E : unmanaged, Enum
    {

    }

    public interface ILiteralKind<E,T> : ILiteralKind<E>, INumericKind<T>
        where T : unmanaged
        where E : unmanaged, Enum

    {

    }    
}