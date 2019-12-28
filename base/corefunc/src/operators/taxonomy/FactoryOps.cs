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
    using static zfunc;

    /// <summary>
    /// Characterizes an operator that produces a target value predicated on a source value
    /// </summary>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="B">The target value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFactoryOp<S,B> : IOp
    {
        B Invoke(S a);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalFactoryOp<S,T> : IFactoryOp<S,T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes an operator that produces a vector predicated on a source value
    /// </summary>
    /// <typeparam name="W">The vector width</typeparam>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="V">The target vector type</typeparam>
    /// <typeparam name="T">The target vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFactoryOp<W,S,V,T> : IFactoryOp<S,V>
        where W : unmanaged, ITypeNat
        where T : unmanaged
        where V : struct
    {

    }

    /// <summary>
    /// Charcterizes an operator that produces a 128-bit target vector predicated on a source value
    /// </summary>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="T">The vector componnet type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFactoryOp128<S,T> : IVFactoryOp<N128,S,Vector128<T>,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Charcterizes an operator that produces a 256-bit target vector predicated on a source value
    /// </summary>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="T">The vector componnet type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFactoryOp256<S,T> : IVFactoryOp<N256,S,Vector256<T>,T>
        where T : unmanaged
    {

    }

}