//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Characterizes an operand-homogenous vectorized merge operator that carries 2 128-bit operands to a 256-bit target
    /// </summary>
    /// <typeparam name="S">The operand component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IMerge2x128x256<S,T> : IFunc<Vector128<S>, Vector128<S>, Vector256<T>>
        where S : unmanaged
        where T : unmanaged
    {

    }
}