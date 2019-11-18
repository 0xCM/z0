//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    /// <summary>
    /// Defines the canonical shape of a unary operator over an unmanaged type
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    public delegate T UnaryOp<T>(T a)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a binary operator over an unmanaged type
    /// </summary>
    /// <param name="a">The left operand</param>
    /// <param name="b">The right operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    public delegate T BinaryOp<T>(T a, T b)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a tenary operator over an unmanaged type
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <param name="c">The third operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    public delegate T TernaryOp<T>(T a, T b, T c)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a bitwise shift function
    /// </summary>
    /// <param name="a">The source value</param>
    /// <param name="offset">The shift amount, typically in bits</param>
    /// <typeparam name="T">The operand type</typeparam>
    public delegate T Shifter<T>(T a, int offset)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a 1-argument function over a parametric domain and boolean codomain
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="T">The domain over which the predicate is evaluated</typeparam>
    public delegate bit UnaryPred<T>(T a)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a 2-argument function over a parametric domain and boolean codomain
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <typeparam name="T">The domain over which the predicate is evaluated</typeparam>
    public delegate bit BinaryPred<T>(T a, T b)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a 3-argument function over a parametric domain and boolean codomain
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <param name="c">The third operand</param>
    /// <typeparam name="T">The domain over which the predicate is evaluated</typeparam>
    public delegate bit TernaryPred<T>(T a, T b, T c)
        where T : unmanaged;

}