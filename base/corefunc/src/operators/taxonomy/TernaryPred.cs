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
    public interface ITernaryPred<A> : IFunc<A,A,A,bit>
    {
        
    }

}