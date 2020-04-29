//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a function reified as a (structural) type, referred to as a (S)tructural (Func)tion
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc
    {
        string Name => Control.ifempty(GetType().Tag<OpKindAttribute>().MapValueOrDefault(a => a.Name), GetType().Name);        
        
        /// <summary>
        /// The operation identity
        /// </summary>
        OpIdentity Id => OpIdentity.Set(Name);        
    }

    /// <summary>
    /// Characterizes a structural function that is width-parametric
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFuncW<W> : IFunc
        where W : unmanaged, ITypeWidth
    {
        TypeWidth TypeWidth => default(W).TypeWidth;
    }

    /// <summary>
    /// Characterizes a width-parametric and T-parameteric structural function
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">Unconstrained</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFuncWT<W,T> : IFuncW<W>
        where W : unmanaged, ITypeWidth
    {

    }
}