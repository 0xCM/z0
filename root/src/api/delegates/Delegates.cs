//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Defines the canonical shape of a unary operator
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T UnaryOp<T>(T a);

    /// <summary>
    /// Characterizes a unary operator with known operand width
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T UnaryOp<W,T>(T a)
        where W : unmanaged, ITypeWidth;

    /// <summary>
    /// Defines the canonical shape of a binary operator
    /// </summary>
    /// <param name="a">The left operand</param>
    /// <param name="b">The right operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T BinaryOp<T>(T a, T b);

    /// <summary>
    /// Characterizes a binary operator with known operand width
    /// </summary>
    /// <param name="a">The left operand</param>
    /// <param name="b">The right operand</param>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T BinaryOp<W,T>(T a, T b)
        where W : unmanaged, ITypeWidth;

    /// <summary>
    /// Defines the canonical shape of a tenary operator
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <param name="c">The third operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T TernaryOp<T>(T a, T b, T c);

    /// <summary>
    /// Characterizes a ternary operator with known operand width
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <param name="c">The third operand</param>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T TernaryOp<W,T>(T a, T b, T c)
        where W : unmanaged, ITypeWidth;

    [SuppressUnmanagedCodeSecurity]
    public delegate A Imm8UnaryOp<A>(A a, byte b);

    [SuppressUnmanagedCodeSecurity]
    public delegate A Imm8BinaryOp<A>(A a, A b, byte c);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate<T>(T a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate<W,T>(T a)
         where W : unmanaged, ITypeWidth<W>;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate<T>(T a, T b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate<W,T>(T a, T b)
         where W : unmanaged, ITypeWidth<W>;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit TernaryPredicate<T>(T a, T b, T c);        

    [SuppressUnmanagedCodeSecurity]
    public delegate bit TernaryPredicate<W,T>(T a, T b, T c)
         where W : unmanaged, ITypeWidth<W>; 
}