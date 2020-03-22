//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Characterizes type classifiers predicated on enumerations
    /// </summary>
    /// <typeparam name="E">The enum type defining potential classifications</typeparam>
    public interface ILiftedEnum<E> : IClassifier
        where E : unmanaged, Enum
    {
        E Class {get;}

        string Name => Class.ToString().ToLower();

    }
 
    public interface ILiteralKind<E> : IKind, ILiftedEnum<E>
        where E : unmanaged, Enum
    {

    }

    public interface ILiteralKind<E,T> : ILiteralKind<E>, INumericKind<T>
        where T : unmanaged
        where E : unmanaged, Enum

    {

    }
}