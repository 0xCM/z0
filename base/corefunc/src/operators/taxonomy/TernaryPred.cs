//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using System.Security;

    /// <summary>
    /// Characterizes a ternary predicate 
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryPred<A> : IOp
    {
        bit Invoke(A a, A b, A c);        
    }

    /// <summary>
    /// Characterizes a ternary predicate over primal operands
    /// </summary>
    /// <typeparam name="T">The primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalTernaryPred<T> : IPrimalOp<T>, ITernaryPred<T>
        where T : unmanaged
    {
        
    }
}