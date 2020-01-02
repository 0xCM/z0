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
    /// Characterizes a function that produces a vector predicated on a source value
    /// </summary>
    /// <typeparam name="W">The vector width</typeparam>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="V">The target vector type</typeparam>
    /// <typeparam name="T">The target vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFactory<W,S,V,T> : IFunc<S,V>
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
    public interface IVFactoryOp128<S,T> : IVFactory<N128,S,Vector128<T>,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Charcterizes an operator that produces a 256-bit target vector predicated on a source value
    /// </summary>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="T">The vector componnet type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFactoryOp256<S,T> : IVFactory<N256,S,Vector256<T>,T>
        where T : unmanaged
    {

    }

}