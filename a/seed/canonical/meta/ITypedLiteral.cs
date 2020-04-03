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
    /// Characterizes type classifiers predicated on enumerations
    /// </summary>
    /// <typeparam name="E">The enum type that defines the classifier superset</typeparam>
    public interface ITypedLiteral<E> : IClassT<E>
        where E : unmanaged, Enum
    {
        E Class {get;}

        string Name => Class.ToString().ToLower();
    }

    /// <summary>
    /// Characterizes parametric typed literals
    /// </summary>
    /// <typeparam name="E">The enum type that defines the classifier superset</typeparam>
    /// <typeparam name="V">The numeric type refined by the enum</typeparam>
    public interface ITypedLiteral<E,V> : ITypedLiteral<E>
        where E : unmanaged, Enum
        where V : unmanaged
    {
        V Value {get;}
    }

}