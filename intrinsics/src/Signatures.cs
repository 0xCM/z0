//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;


    /// <summary>
    /// Characterizes the signature of a 128-bit cpu vector unary operator
    /// </summary>
    /// <param name="src">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vector128<T> Vector128UnaryOp<T>(Vector128<T> src)
        where T : unmanaged;

    /// <summary>
    /// Characterizes the signature of a 128-bit vector binary operator
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vector128<T> Vector128BinOp<T>(Vector128<T> lhs, Vector128<T> rhs)
        where T : unmanaged;

    /// <summary>
    /// Characterizes the signature of a 256-bit cpu vector unary operator
    /// </summary>
    /// <param name="src">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vector256<T> Vector256UnaryOp<T>(Vector256<T> src)
        where T : unmanaged;

    /// <summary>
    /// Characterizes the signature of a 256-bit vector binary operator
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vector256<T> Vector256BinOp<T>(Vector256<T> x, Vector256<T> y)
        where T : unmanaged;
}
