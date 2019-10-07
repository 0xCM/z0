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
    /// Characterizes the signature of a canonical 128-bit vector binary operator
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec128<T> Vec128BinOp<T>(in Vec128<T> lhs, in Vec128<T> rhs)
        where T : unmanaged;

    /// <summary>
    /// Characterizes the signature of a 128-bit vector intrinsic unary operator
    /// </summary>
    /// <param name="src">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec128<T> Vec128UnaryOp<T>(in Vec128<T> src)
        where T : unmanaged;


    public delegate Vec256<T> Vec256BinOp<T>(in Vec256<T> lhs, in Vec256<T> rhs)
        where T : unmanaged;

    /// <summary>
    /// Characterizes the signature of a canonical 256-bit vector heterogenous binary operator
    /// </summary>
    /// <param name="lhs">The left operand</param>
    /// <param name="rhs">The right operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec256<T> Vec256BinOp<S, T>(in Vec256<S> lhs, in Vec256<S> rhs)
        where T : unmanaged
        where S : unmanaged;

    /// <summary>
    /// Characterizes the signature of a 256-bit vector intrinsic unary operator
    /// </summary>
    /// <param name="src">The operand</param>
    /// <typeparam name="T">The primitive type</typeparam>
    public delegate Vec256<T> Vec256UnaryOp<T>(in Vec256<T> src)
        where T : unmanaged;


}
