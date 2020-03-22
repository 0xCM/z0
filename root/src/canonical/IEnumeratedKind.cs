//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    

    public interface ILiftedEnum<E> : IClassifier
        where E : unmanaged, Enum
    {
        E Class {get;}

        string Name => Class.ToString().ToLower();

    }

    /// <summary>
    /// Characterizes type classifiers predicated on enumerations
    /// </summary>
    /// <typeparam name="E">The enum type defining potential classifications</typeparam>
    public interface IEnumeratedKind<E> : IKind, ILiftedEnum<E>
        where E : unmanaged, Enum
    {

    }

    public interface IEnumeratedKind<K,E> : IEnumeratedKind<E>
        where E : unmanaged, Enum
        where K : struct, IEnumeratedKind<K,E>
    {

    }

    public interface ILiteralKind<E> : IEnumeratedKind<E>
        where E : unmanaged, Enum
    {

    }

    public interface ILiteralKind<E,T> : ILiteralKind<E>, INumericKind<T>
        where T : unmanaged
        where E : unmanaged, Enum

    {

    }
}