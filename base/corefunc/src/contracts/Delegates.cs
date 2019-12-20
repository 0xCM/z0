//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Characterizes a unary operator reified as a member function
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IUnaryOp<T>
    {
        T Invoke(T a);        
    }

    /// <summary>
    /// Characterizes a binary operator reified as a member function
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IBinaryOp<T>
    {
        T Invoke(T a, T b);        
    }

    /// <summary>
    /// Characterizes a ternary operator reified as a member function
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface ITernaryOp<T>
    {
        T Invoke(T a, T b, T c);        
    }

    /// <summary>
    /// Characterizes a unary predicate reified as a member function
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IUnaryPred<T>
    {
        bit Invoke(T a, T b);        
    }

    /// <summary>
    /// Characterizes a binary predicate reified as a member function
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IBinaryPred<T>
    {
        bit Invoke(T a, T b);        
    }

    /// <summary>
    /// Characterizes a ternary predicate reified as a member function
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface ITernaryPred<T>
    {
        bit Invoke(T a, T b, T c);        
    }

    /// <summary>
    /// Characterizes a bitwise shift/rotate fucntion as a member
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IShifter<T>
    {
        T Invoke(T a, byte offset);        
    }

    /// <summary>
    /// Defines the canonical shape of a unary operator over an unmanaged type
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T UnaryOp<T>(T a)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a binary operator over an unmanaged type
    /// </summary>
    /// <param name="a">The left operand</param>
    /// <param name="b">The right operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T BinaryOp<T>(T a, T b)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a binary operator over 128-bit intrinsic vectors
    /// </summary>
    /// <param name="x">The left vector</param>
    /// <param name="y">The right vector</param>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate Vector128<T> BinaryOp128<T>(Vector128<T> x, Vector128<T> y)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a binary operator over 256-bit intrinsic vectors
    /// </summary>
    /// <param name="x">The left vector</param>
    /// <param name="y">The right vector</param>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate Vector256<T> BinaryOp256<T>(Vector256<T> x, Vector256<T> y)
        where T : unmanaged;

    /// <summary>
    /// Defines the shape of a common intrinsic bitwise shift function that accepts an immediate byte to specify offset
    /// </summary>
    /// <param name="a">The source value</param>
    /// <param name="offset">The shift amount, typically in bits</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Shifter128<T>(Vector128<T> a, byte offset)
        where T : unmanaged;


    /// <summary>
    /// Defines the canonical shape of a tenary operator over an unmanaged type
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <param name="c">The third operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T TernaryOp<T>(T a, T b, T c)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a bitwise shift function
    /// </summary>
    /// <param name="a">The source value</param>
    /// <param name="offset">The shift amount, typically in bits</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Shifter<T>(T a, int offset)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a 1-argument function over a parametric domain and boolean codomain
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="T">The domain over which the predicate is evaluated</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPred<T>(T a)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a 2-argument function over a parametric domain and boolean codomain
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <typeparam name="T">The domain over which the predicate is evaluated</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPred<T>(T a, T b)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a 3-argument function over a parametric domain and boolean codomain
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <param name="c">The third operand</param>
    /// <typeparam name="T">The domain over which the predicate is evaluated</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate bit TernaryPred<T>(T a, T b, T c)
        where T : unmanaged;
}