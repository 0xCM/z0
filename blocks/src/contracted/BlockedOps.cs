//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    /// <summary>
    /// Base interface for block-oriented operations
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedOp : IFunc
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedOp<W> : IBlockedOp
        where W : unmanaged, ITypeNat
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedOp<W,T> : IBlockedOp<W>
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {

    }
}