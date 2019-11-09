//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    public delegate T UnaryOp<T>(T a)
        where T : unmanaged;

    public delegate T BinaryOp<T>(T a, T b)
        where T : unmanaged;

    public delegate T TernaryOp<T>(T a, T b, T c)
        where T : unmanaged;

    public delegate T Shifter<T>(T a, int offset)
        where T : unmanaged;

    /// <summary>
    /// Represents a unary function over a parametric domain and boolean codomain
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="T">The domain over which the predicate is evaluated</typeparam>
    public delegate bit UnaryPred<T>(T a)
        where T : unmanaged;

    /// <summary>
    /// Represents a binary function over a parametric domain and boolean codomain
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <typeparam name="T">The domain over which the predicate is evaluated</typeparam>
    public delegate bit BinaryPred<T>(T a, T b)
        where T : unmanaged;

    /// <summary>
    /// Represents a ternary function over a parametric domain and boolean codomain
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <param name="c">The third operand</param>
    /// <typeparam name="T">The domain over which the predicate is evaluated</typeparam>
    public delegate bit TernaryPred<T>(T a, T b, T c)
        where T : unmanaged;

}