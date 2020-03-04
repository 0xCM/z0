//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;
    using System.Security;
    
    /// <summary>
    /// Characterizes a binary function
    /// </summary>
    /// <typeparam name="A">The left operand type</typeparam>
    /// <typeparam name="B">The right operand type</typeparam>
    /// <typeparam name="C">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryFunc<A,B,C> : IFunc<A,B,C>
    {
        
    }

    /// <summary>
    /// Characterizes a binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOp<A> : IBinaryFunc<A,A,A>
    {
    
    }

    /// <summary>
    /// Characterizes a binary operator that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinOpImm8<A> : IFunc<A,A,byte,A>
    {

    }
}