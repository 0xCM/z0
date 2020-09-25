//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a structural function that is width-parametric
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [Free]
    public interface IFuncW<W> : IFunc
        where W : unmanaged, ITypeWidth
    {
        TypeWidth TypeWidth
            => default(W).TypeWidth;
    }

    /// <summary>
    /// Characterizes a width-parametric and T-parameteric structural function
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">Unconstrained</typeparam>
    [Free]
    public interface IFuncWT<W,T> : IFuncW<W>
        where W : unmanaged, ITypeWidth
    {

    }
}