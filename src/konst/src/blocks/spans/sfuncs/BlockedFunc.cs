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
    /// Characterizes structured blocked functions
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedFunc : IFunc
    {
        OpIdentity IFunc.Id => OpIdentity.Empty;
    }

    /// <summary>
    /// Characterizes identified SBF operations that are width-parametric
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedFunc<W> : IBlockedFunc
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes identified SBF operations that are cell and width-parametric
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBlockedFunc<W,T> : IBlockedFunc<W>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}