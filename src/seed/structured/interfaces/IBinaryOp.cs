//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a structural binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOp<A> : IFunc<A,A,A>
    {
        new BinaryOp<A> Operation => (this as IFunc<A,A,A>).Operation.ToBinaryOp();    
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOpIn<A> : IFuncIn<A,A,A>
    {

    }
}