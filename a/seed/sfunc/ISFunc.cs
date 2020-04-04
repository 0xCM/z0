//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IStructuralOperation
    {
        
    }

    /// <summary>
    /// Characterizes a function reified as a (structural) type, referred to as a (S)tructural (Func)tion
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFunc : IStructuralOperation
    {

    }

    /// <summary>
    /// Characterizes an identified structural function
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFuncApi : ISFunc
    {
        /// <summary>
        /// The operation identity
        /// </summary>
        OpIdentity Id {get;} 
    }
}