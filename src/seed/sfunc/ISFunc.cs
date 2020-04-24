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
    public interface ISFunc
    {
        string Name => Control.ifempty(GetType().Tag<OpKindAttribute>().MapValueOrDefault(a => a.Name), GetType().Name);        
        
        /// <summary>
        /// The operation identity
        /// </summary>
        OpIdentity Id => OpIdentity.Set(Name);        
    }
}