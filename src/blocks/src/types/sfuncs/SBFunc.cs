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
    /// Characterizes identified (S)tructed (B)blocked functions
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ISBFuncApi : ISFunc
    {

    }

    /// <summary>
    /// Characterizes identified SBF operations that are width-parametric, homoenously so
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]    
    public interface ISBFuncApi<W> : ISBFuncApi
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes identified SBF operations that are cell and width-parametric, homoenously both
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISBOpApi<W,T> : ISBFuncApi<W>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}