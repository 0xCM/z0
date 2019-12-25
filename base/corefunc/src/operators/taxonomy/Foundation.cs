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
    /// Base operator characterization
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IOp
    {
        /// <summary>
        /// A name that uniquely identifies an operator reification
        /// </summary>
        string Moniker {get;}        
    }


    [SuppressUnmanagedCodeSecurity]
    public interface IVectorOp<T> : IOp
        where T : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalOp<T> : IOp
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVectorOp<W,V> : IOp
        where V : struct
        where W : unmanaged, ITypeNat
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVectorOp<W,V,T> : IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where T : unmanaged
        where V : struct
    {

    }
}