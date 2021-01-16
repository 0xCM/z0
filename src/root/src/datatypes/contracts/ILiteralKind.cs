//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a parametric literal: typed literals that support kind partitioning
    /// </summary>
    /// <typeparam name="E">The classifying enum type</typeparam>
    public interface ILiteralKind<E> : ITypedLiteral<E>
        where E : unmanaged, Enum
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphic E-parametric literal reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="E">The classifier type</typeparam>
    public interface ILiteralKind<F,E> : ILiteralKind<E>
        where F : ILiteralKind<F,E>, new()
        where E : unmanaged, Enum
    {

    }

    /// <summary>
    /// Characterizes a T-parametric literal kind
    /// </summary>
    /// <typeparam name="K">The literal kind </typeparam>
    /// <typeparam name="E">The kind classifier type</typeparam>
    /// <typeparam name="T">Free</typeparam>
    public interface ILiteralKind<F,E,T> : ILiteralKind<E>
        where F : ILiteralKind<E>, new()
        where E : unmanaged, Enum
    {
        E ITypedLiteral<E>.Class
            => new F().Class;
    }
}