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


    /// <summary>
    /// Characterizes a ternary function
    /// </summary>
    /// <typeparam name="A">The left operand type</typeparam>
    /// <typeparam name="B">The right operand type</typeparam>
    /// <typeparam name="C">The third operand type</typeparam>
    /// <typeparam name="D">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryFunc<A,B,C,D> : IFunc<A,B,C,D>
    {
        
    }

    /// <summary>
    /// Characterizes a ternary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryOp<A> : ITernaryFunc<A,A,A,A>
    {

    }

 
}