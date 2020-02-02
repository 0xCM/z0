//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;
    using static zfunc;

    /// <summary>
    /// Defines the canonical shape of a value emitter
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Emitter<T>();

    /// <summary>
    /// Defines the canonical shape of a unary operator
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T UnaryOp<T>(T a);

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
    /// Defines the canonical shape of a binary operator
    /// </summary>
    /// <param name="a">The left operand</param>
    /// <param name="b">The right operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T BinaryOp<T>(T a, T b);


    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block128<T> UnaryBlockedOp128<T>(in Block128<T> src, in Block128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block256<T> UnaryBlockedOp256<T>(in Block256<T> src, in Block256<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block128<T> BinaryBlockedOp128<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block256<T> BinaryBlockedOp256<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block128<T> UnaryBlockedOp128Imm8<T>(in Block128<T> src, byte imm8, in Block128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block256<T> UnaryBlockedOp256Imm8<T>(in Block256<T> src, byte imm8, in Block256<T> dst)
        where T : unmanaged;

}
